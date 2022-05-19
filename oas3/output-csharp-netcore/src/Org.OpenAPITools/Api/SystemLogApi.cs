/*
 * Okta API
 *
 * Allows customers to easily access the Okta API
 *
 * The version of the OpenAPI document: 2.10.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemLogApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fetch a list of events from your Okta organization system log.
        /// </summary>
        /// <remarks>
        /// The Okta System Log API provides read access to your organization’s system log. This API provides more functionality than the Events API
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since"> (optional)</param>
        /// <param name="until"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="q"> (optional)</param>
        /// <param name="limit"> (optional, default to 100)</param>
        /// <param name="sortOrder"> (optional, default to &quot;ASCENDING&quot;)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>List&lt;LogEvent&gt;</returns>
        List<LogEvent> GetLogs(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string filter = default(string), string q = default(string), int? limit = default(int?), string sortOrder = default(string), string after = default(string));

        /// <summary>
        /// Fetch a list of events from your Okta organization system log.
        /// </summary>
        /// <remarks>
        /// The Okta System Log API provides read access to your organization’s system log. This API provides more functionality than the Events API
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since"> (optional)</param>
        /// <param name="until"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="q"> (optional)</param>
        /// <param name="limit"> (optional, default to 100)</param>
        /// <param name="sortOrder"> (optional, default to &quot;ASCENDING&quot;)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>ApiResponse of List&lt;LogEvent&gt;</returns>
        ApiResponse<List<LogEvent>> GetLogsWithHttpInfo(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string filter = default(string), string q = default(string), int? limit = default(int?), string sortOrder = default(string), string after = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemLogApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Fetch a list of events from your Okta organization system log.
        /// </summary>
        /// <remarks>
        /// The Okta System Log API provides read access to your organization’s system log. This API provides more functionality than the Events API
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since"> (optional)</param>
        /// <param name="until"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="q"> (optional)</param>
        /// <param name="limit"> (optional, default to 100)</param>
        /// <param name="sortOrder"> (optional, default to &quot;ASCENDING&quot;)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;LogEvent&gt;</returns>
        System.Threading.Tasks.Task<List<LogEvent>> GetLogsAsync(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string filter = default(string), string q = default(string), int? limit = default(int?), string sortOrder = default(string), string after = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Fetch a list of events from your Okta organization system log.
        /// </summary>
        /// <remarks>
        /// The Okta System Log API provides read access to your organization’s system log. This API provides more functionality than the Events API
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since"> (optional)</param>
        /// <param name="until"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="q"> (optional)</param>
        /// <param name="limit"> (optional, default to 100)</param>
        /// <param name="sortOrder"> (optional, default to &quot;ASCENDING&quot;)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;LogEvent&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LogEvent>>> GetLogsWithHttpInfoAsync(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string filter = default(string), string q = default(string), int? limit = default(int?), string sortOrder = default(string), string after = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemLogApi : ISystemLogApiSync, ISystemLogApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SystemLogApi : ISystemLogApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemLogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemLogApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemLogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemLogApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemLogApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SystemLogApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemLogApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SystemLogApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Fetch a list of events from your Okta organization system log. The Okta System Log API provides read access to your organization’s system log. This API provides more functionality than the Events API
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since"> (optional)</param>
        /// <param name="until"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="q"> (optional)</param>
        /// <param name="limit"> (optional, default to 100)</param>
        /// <param name="sortOrder"> (optional, default to &quot;ASCENDING&quot;)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>List&lt;LogEvent&gt;</returns>
        public List<LogEvent> GetLogs(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string filter = default(string), string q = default(string), int? limit = default(int?), string sortOrder = default(string), string after = default(string))
        {
            Org.OpenAPITools.Client.ApiResponse<List<LogEvent>> localVarResponse = GetLogsWithHttpInfo(since, until, filter, q, limit, sortOrder, after);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a list of events from your Okta organization system log. The Okta System Log API provides read access to your organization’s system log. This API provides more functionality than the Events API
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since"> (optional)</param>
        /// <param name="until"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="q"> (optional)</param>
        /// <param name="limit"> (optional, default to 100)</param>
        /// <param name="sortOrder"> (optional, default to &quot;ASCENDING&quot;)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>ApiResponse of List&lt;LogEvent&gt;</returns>
        public Org.OpenAPITools.Client.ApiResponse<List<LogEvent>> GetLogsWithHttpInfo(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string filter = default(string), string q = default(string), int? limit = default(int?), string sortOrder = default(string), string after = default(string))
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (since != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "since", since));
            }
            if (until != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "until", until));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (q != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "q", q));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "after", after));
            }

            // authentication (api_token) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<LogEvent>>("/api/v1/logs", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLogs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetch a list of events from your Okta organization system log. The Okta System Log API provides read access to your organization’s system log. This API provides more functionality than the Events API
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since"> (optional)</param>
        /// <param name="until"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="q"> (optional)</param>
        /// <param name="limit"> (optional, default to 100)</param>
        /// <param name="sortOrder"> (optional, default to &quot;ASCENDING&quot;)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;LogEvent&gt;</returns>
        public async System.Threading.Tasks.Task<List<LogEvent>> GetLogsAsync(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string filter = default(string), string q = default(string), int? limit = default(int?), string sortOrder = default(string), string after = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<List<LogEvent>> localVarResponse = await GetLogsWithHttpInfoAsync(since, until, filter, q, limit, sortOrder, after, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a list of events from your Okta organization system log. The Okta System Log API provides read access to your organization’s system log. This API provides more functionality than the Events API
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since"> (optional)</param>
        /// <param name="until"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="q"> (optional)</param>
        /// <param name="limit"> (optional, default to 100)</param>
        /// <param name="sortOrder"> (optional, default to &quot;ASCENDING&quot;)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;LogEvent&gt;)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<List<LogEvent>>> GetLogsWithHttpInfoAsync(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string filter = default(string), string q = default(string), int? limit = default(int?), string sortOrder = default(string), string after = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (since != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "since", since));
            }
            if (until != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "until", until));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (q != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "q", q));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "after", after));
            }

            // authentication (api_token) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<LogEvent>>("/api/v1/logs", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLogs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
