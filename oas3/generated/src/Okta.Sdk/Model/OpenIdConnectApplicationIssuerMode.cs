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
    /// Defines OpenIdConnectApplicationIssuerMode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum OpenIdConnectApplicationIssuerMode
    {
        /// <summary>
        /// Enum CUSTOMURL for value: CUSTOM_URL
        /// </summary>
        [EnumMember(Value = "CUSTOM_URL")]
        CUSTOMURL = 1,
        /// <summary>
        /// Enum ORGURL for value: ORG_URL
        /// </summary>
        [EnumMember(Value = "ORG_URL")]
        ORGURL = 2    }
}
