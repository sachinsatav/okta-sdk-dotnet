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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines ProtocolRelayStateFormat
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProtocolRelayStateFormat
    {
        /// <summary>
        /// Enum OPAQUE for value: OPAQUE
        /// </summary>
        [EnumMember(Value = "OPAQUE")]
        OPAQUE = 1,

        /// <summary>
        /// Enum FROMURL for value: FROM_URL
        /// </summary>
        [EnumMember(Value = "FROM_URL")]
        FROMURL = 2

    }

}
