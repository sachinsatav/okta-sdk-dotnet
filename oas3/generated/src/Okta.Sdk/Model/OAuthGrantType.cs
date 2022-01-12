/* 
 * Okta API
 *
 * Allows customers to easily access the Okta API
 *
 * OpenAPI spec version: 2.9.2
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Okta.Sdk.Client.SwaggerDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Defines OAuthGrantType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum OAuthGrantType
    {
        /// <summary>
        /// Enum Authorizationcode for value: authorization_code
        /// </summary>
        [EnumMember(Value = "authorization_code")]
        Authorizationcode = 1,
        /// <summary>
        /// Enum Implicit for value: implicit
        /// </summary>
        [EnumMember(Value = "implicit")]
        Implicit = 2,
        /// <summary>
        /// Enum Password for value: password
        /// </summary>
        [EnumMember(Value = "password")]
        Password = 3,
        /// <summary>
        /// Enum Refreshtoken for value: refresh_token
        /// </summary>
        [EnumMember(Value = "refresh_token")]
        Refreshtoken = 4,
        /// <summary>
        /// Enum Clientcredentials for value: client_credentials
        /// </summary>
        [EnumMember(Value = "client_credentials")]
        Clientcredentials = 5    }
}
