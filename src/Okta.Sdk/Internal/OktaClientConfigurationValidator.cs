﻿// <copyright file="OktaClientConfigurationValidator.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Text.RegularExpressions;
using Okta.Sdk.Configuration;

namespace Okta.Sdk.Internal
{
    /// <summary>
    /// Helper validator class for OktaClient settings
    /// </summary>
    public class OktaClientConfigurationValidator
    {
        /// <summary>
        /// Validates the OktaClient configuration
        /// </summary>
        /// <param name="configuration">The configuration to be validated</param>
        /// <param name="isExternalTokenProviderDefined">If there is an external token provider to be used to retrieve BearerToken.</param>
        public static void Validate(OktaClientConfiguration configuration, bool isExternalTokenProviderDefined = false)
        {
            if (string.IsNullOrEmpty(configuration.OktaDomain))
            {
                throw new ArgumentNullException(nameof(configuration.OktaDomain), "Your Okta URL is missing. You can copy your domain from the Okta Developer Console. Follow these instructions to find it: https://bit.ly/finding-okta-domain");
            }

            configuration.OktaDomain = EnsureTrailingSlash(configuration.OktaDomain);

            if (!configuration.DisableHttpsCheck && !configuration.OktaDomain.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException($"Your Okta URL must start with https. Current value: {configuration.OktaDomain}. You can copy your domain from the Okta Developer Console. Follow these instructions to find it: https://bit.ly/finding-okta-domain", nameof(configuration.OktaDomain));
            }

            if (configuration.OktaDomain.IndexOf("{yourOktaDomain}", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                throw new ArgumentNullException(nameof(configuration.OktaDomain), "Replace {yourOktaDomain} with your Okta domain. You can copy your domain from the Okta Developer Console. Follow these instructions to find it: https://bit.ly/finding-okta-domain");
            }

            if (configuration.OktaDomain.IndexOf("-admin.okta.com", StringComparison.OrdinalIgnoreCase) >= 0 ||
                configuration.OktaDomain.IndexOf("-admin.oktapreview.com", StringComparison.OrdinalIgnoreCase) >= 0 ||
                configuration.OktaDomain.IndexOf("-admin.okta-emea.com", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                throw new ArgumentNullException(nameof(configuration.OktaDomain), $"Your Okta domain should not contain -admin. Current value: {configuration.OktaDomain}. You can copy your domain from the Okta Developer Console. Follow these instructions to find it: https://bit.ly/finding-okta-domain");
            }

            if (configuration.OktaDomain.IndexOf(".com.com", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                throw new ArgumentNullException(nameof(configuration.OktaDomain), $"It looks like there's a typo in your Okta domain. Current value: {configuration.OktaDomain}. You can copy your domain from the Okta Developer Console. Follow these instructions to find it: https://bit.ly/finding-okta-domain");
            }

            if (Regex.Matches(configuration.OktaDomain, "://").Count != 1)
            {
                throw new ArgumentNullException(nameof(configuration.OktaDomain), $"It looks like there's a typo in your Okta domain. Current value: {configuration.OktaDomain}. You can copy your domain from the Okta Developer Console. Follow these instructions to find it: https://bit.ly/finding-okta-domain");
            }

            if (configuration.AuthorizationMode == AuthorizationMode.SSWS)
            {
                if (string.IsNullOrEmpty(configuration.Token))
                {
                    throw new ArgumentNullException(nameof(configuration.Token), "Your Okta API token is missing. You can generate one in the Okta Developer Console. Follow these instructions: https://bit.ly/get-okta-api-token");
                }

                if (configuration.Token.IndexOf("{apiToken}", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    throw new ArgumentException("Replace {apiToken} with your Okta API token. You can generate one in the Okta Developer Console. Follow these instructions: https://bit.ly/get-okta-api-token", nameof(configuration.Token));
                }
            }

            if (configuration.AuthorizationMode == AuthorizationMode.PrivateKey)
            {
                if (string.IsNullOrEmpty(configuration.ClientId))
                {
                    throw new ArgumentNullException(nameof(configuration.ClientId), "Your client ID is missing. You can copy it from the Okta Developer Console in the details for the Application you created. Follow these instructions to find it: https://bit.ly/finding-okta-app-credentials");
                }

                if (configuration.ClientId.IndexOf("{ClientId}", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    throw new ArgumentNullException(
                        nameof(configuration.ClientId),
                        "Replace {clientId} with the client ID of your Application. You can copy it from the Okta Developer Console in the details for the Application you created. Follow these instructions to find it: https://bit.ly/finding-okta-app-credentials");
                }

                if (configuration.PrivateKey == null)
                {
                    throw new ArgumentNullException(nameof(configuration.PrivateKey), "Your private key is missing.");
                }

                if (configuration.Scopes == null || configuration.Scopes.Count == 0)
                {
                    throw new ArgumentNullException(nameof(configuration.Scopes), "Scopes cannot be null or empty.");
                }
            }

            if (configuration.AuthorizationMode == AuthorizationMode.BearerToken)
            {
                if (string.IsNullOrEmpty(configuration.BearerToken) && !isExternalTokenProviderDefined)
                {
                    throw new ArgumentNullException(
                        nameof(configuration.AuthorizationMode),
                        $"{nameof(configuration.BearerToken)} configuration property cannot be null when AuthorizationMode.BearerToken is selected.");
                }
            }
        }

        /// <summary>
        /// Ensures that this URI ends with a trailing slash <c>/</c>
        /// </summary>
        /// <param name="oktaDomain">The okta domain URI string</param>
        /// <returns>The URI string, appended with <c>/</c> if necessary.</returns>
        public static string EnsureTrailingSlash(string oktaDomain)
        {
            if (!oktaDomain.EndsWith("/"))
            {
                oktaDomain += "/";
            }

            return oktaDomain;
        }
    }
}
