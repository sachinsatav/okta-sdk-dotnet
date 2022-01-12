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
    /// Defines OpenIdConnectRefreshTokenRotationType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum OpenIdConnectRefreshTokenRotationType
    {
        /// <summary>
        /// Enum Rotate for value: rotate
        /// </summary>
        [EnumMember(Value = "rotate")]
        Rotate = 1,
        /// <summary>
        /// Enum Static for value: static
        /// </summary>
        [EnumMember(Value = "static")]
        Static = 2    }
}
