﻿// <copyright file="DefaultRequestExecutor.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Okta.Sdk.Configuration;

namespace Okta.Sdk.Internal
{
    /// <summary>
    /// The default implementation of <see cref="IRequestExecutor"/> that uses <c>System.Net.Http</c>.
    /// </summary>
    public sealed class DefaultRequestExecutor : IRequestExecutor
    {
        private const string OktaClientUserAgentName = "oktasdk-dotnet";

        private readonly string _oktaDomain;
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;
        private readonly IRetryStrategy _retryStrategy;
        private readonly IOAuthTokenProvider _oAuthTokenProvider;
        private readonly OktaClientConfiguration _oktaConfiguration;
        private readonly IHttpRequestMessageProvider _httpRequestMessageProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultRequestExecutor"/> class.
        /// </summary>
        protected DefaultRequestExecutor() // to enable testing
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultRequestExecutor"/> class.
        /// </summary>
        /// <param name="configuration">The client configuration.</param>
        /// <param name="httpClient">The HTTP client to use, if any.</param>
        /// <param name="logger">The logging interface.</param>
        /// <param name="retryStrategy">The retry strategy interface.</param>
        /// <param name="oAuthTokenProvider">The OAuth token provider interface.</param>
        public DefaultRequestExecutor(OktaClientConfiguration configuration, HttpClient httpClient, ILogger logger, IRetryStrategy retryStrategy = null, IOAuthTokenProvider oAuthTokenProvider = null, IHttpRequestMessageProvider httpRequestMessageProvider = null)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            _oktaDomain = configuration.OktaDomain;
            _logger = logger;
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _retryStrategy = retryStrategy ?? new DefaultRetryStrategy(configuration.MaxRetries.Value, configuration.RequestTimeout.Value);
            _oAuthTokenProvider = oAuthTokenProvider ?? NullOAuthTokenProvider.Instance;
            _oktaConfiguration = configuration;
            _httpRequestMessageProvider = httpRequestMessageProvider ?? HttpRequestMessageProvider.Default;
            ApplyDefaultClientSettings(_httpClient, _oktaDomain, configuration);
        }

        private static void ApplyDefaultClientSettings(HttpClient client, string oktaDomain, OktaClientConfiguration configuration)
        {
            client.BaseAddress = new Uri(oktaDomain, UriKind.Absolute);

            if (configuration.AuthorizationMode == AuthorizationMode.SSWS)
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("SSWS", configuration.Token);
            }
        }

        private async Task ApplyOAuthHeaderAsync(bool forceTokenRenew = false)
        {
            var token = await _oAuthTokenProvider.GetAccessTokenAsync(forceTokenRenew).ConfigureAwait(false);
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            }
        }

        private string EnsureRelativeUrl(string uri)
        {
            if (string.IsNullOrEmpty(uri))
            {
                throw new ArgumentException("The request URI was empty.");
            }

            if (uri.StartsWith(_oktaDomain))
            {
                return uri.Replace(_oktaDomain, string.Empty);
            }

            if (uri.Contains("://"))
            {
                throw new InvalidOperationException($"The client is configured to connect to {_oktaDomain}, but this request URI does not match: ${uri}");
            }

            return uri.TrimStart('/');
        }

        private async Task<HttpResponse<string>> ProcessResponseAsync(HttpResponseMessage response)
        {
            string stringContent = null;
            if (response.Content != null)
            {
                stringContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }

            return new HttpResponse<string>
            {
                Headers = ExtractHeaders(response),
                StatusCode = (int)response.StatusCode,
                Payload = stringContent,
            };
        }

        private async Task<HttpResponse<string>> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            _logger.LogTrace($"{request.Method} {request.RequestUri}");

            await ApplyOAuthHeaderAsync().ConfigureAwait(false);

            Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> operation = async (x, y) => await _httpClient.SendAsync(x, y).ConfigureAwait(false);
            HttpResponseMessage response = null;

            using (response = await _retryStrategy.WaitAndRetryAsync(request, cancellationToken, operation).ConfigureAwait(false))
            {
                _logger.LogTrace($"{(int)response.StatusCode} {request.RequestUri.PathAndQuery}");

                // If OAuth token expired, get a new token and retry
                if ((int)response.StatusCode == 401 &&
                    (_oktaConfiguration.AuthorizationMode == AuthorizationMode.PrivateKey ||
                     _oktaConfiguration.AuthorizationMode == AuthorizationMode.BearerToken))
                {
                    await ApplyOAuthHeaderAsync(true).ConfigureAwait(false);

                    // Sending same request twice cause failures
                    var clonedRequest = await HttpRequestMessageHelper
                        .CloneHttpRequestMessageAsync(request, skipAuthorizationHeader: true)
                        .ConfigureAwait(false);

                    using (response = await _retryStrategy.WaitAndRetryAsync(clonedRequest, cancellationToken, operation).ConfigureAwait(false))
                    {
                        return await ProcessResponseAsync(response).ConfigureAwait(false);
                    }
                }

                return await ProcessResponseAsync(response).ConfigureAwait(false);
            }
        }

        private static void ApplyHeadersToRequest(HttpRequestMessage request, IEnumerable<KeyValuePair<string, string>> headers)
        {
            if (headers == null || !headers.Any())
            {
                return;
            }

            foreach (var header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }
        }

        private static IEnumerable<KeyValuePair<string, IEnumerable<string>>> ExtractHeaders(HttpResponseMessage response)
        {
            if (response.Content != null && response.Content.Headers != null)
            {
                return response.Headers?.Concat(response.Content.Headers);
            }
            else
            {
                return response.Headers;
            }
        }

        /// <inheritdoc/>
        public async Task<HttpResponse<string>> ExecuteRequestAsync(HttpRequest request, CancellationToken cancellationToken)
        {
            switch (request.Verb)
            {
                case HttpVerb.Get:
                    return await GetAsync(request.Uri, request.Headers, cancellationToken).ConfigureAwait(false);
                case HttpVerb.Post:
                    return await PostAsync(request.Uri, request.Headers, request.GetBody(), cancellationToken).ConfigureAwait(false);
                case HttpVerb.Put:
                    return await PutAsync(request.Uri, request.Headers, request.GetBody(), cancellationToken).ConfigureAwait(false);
                case HttpVerb.Delete:
                    return await DeleteAsync(request.Uri, request.Headers, cancellationToken).ConfigureAwait(false);
                default:
                    return await GetAsync(request.Uri, request.Headers, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public Task<HttpResponse<string>> GetAsync(string href, IEnumerable<KeyValuePair<string, string>> headers, CancellationToken cancellationToken)
        {
            var path = EnsureRelativeUrl(href);

            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(path, UriKind.Relative));
            ApplyHeadersToRequest(request, headers);

            return SendAsync(request, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<HttpResponse<string>> PostAsync(HttpRequest httpRequest, CancellationToken cancellationToken)
        {
            return SendAsync(_httpRequestMessageProvider.CreateHttpRequestMessage(httpRequest, EnsureRelativeUrl(httpRequest.Uri)), cancellationToken);
        }

        /// <inheritdoc/>
        public Task<HttpResponse<string>> PostAsync(string href, IEnumerable<KeyValuePair<string, string>> headers, string body, CancellationToken cancellationToken)
        {
            var path = EnsureRelativeUrl(href);

            var request = new HttpRequestMessage(HttpMethod.Post, new Uri(path, UriKind.Relative));
            ApplyHeadersToRequest(request, headers);

            request.Content = string.IsNullOrEmpty(body)
                ? null
                : new StringContent(body, System.Text.Encoding.UTF8, "application/json");

            return SendAsync(request, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<HttpResponse<string>> PutAsync(string href, IEnumerable<KeyValuePair<string, string>> headers, string body, CancellationToken cancellationToken)
        {
            var path = EnsureRelativeUrl(href);

            var request = new HttpRequestMessage(HttpMethod.Put, new Uri(path, UriKind.Relative));
            ApplyHeadersToRequest(request, headers);

            request.Content = string.IsNullOrEmpty(body)
                ? null
                : new StringContent(body, System.Text.Encoding.UTF8, "application/json");

            return SendAsync(request, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<HttpResponse<string>> DeleteAsync(string href, IEnumerable<KeyValuePair<string, string>> headers, CancellationToken cancellationToken)
        {
            var path = EnsureRelativeUrl(href);

            var request = new HttpRequestMessage(HttpMethod.Delete, new Uri(path, UriKind.Relative));
            ApplyHeadersToRequest(request, headers);

            return SendAsync(request, cancellationToken);
        }
    }
}
