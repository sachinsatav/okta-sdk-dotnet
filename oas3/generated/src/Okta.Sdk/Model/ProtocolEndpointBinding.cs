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
    /// Defines ProtocolEndpointBinding
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolEndpointBinding
    {
        /// <summary>
        /// Enum POST for value: HTTP-POST
        /// </summary>
        [EnumMember(Value = "HTTP-POST")]
        POST = 1,
        /// <summary>
        /// Enum REDIRECT for value: HTTP-REDIRECT
        /// </summary>
        [EnumMember(Value = "HTTP-REDIRECT")]
        REDIRECT = 2    }
}
