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
    /// Defines AuthorizationServerCredentialsUse
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthorizationServerCredentialsUse
    {
        /// <summary>
        /// Enum Sig for value: sig
        /// </summary>
        [EnumMember(Value = "sig")]
        Sig = 1    }
}
