/*
 * Okta API
 *
 * Allows customers to easily access the Okta API
 *
 * The version of the OpenAPI document: 3.0.0
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
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Defines DNSRecordType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DNSRecordType
    {
        /// <summary>
        /// Enum CNAME for value: CNAME
        /// </summary>
        [EnumMember(Value = "CNAME")]
        CNAME = 1,

        /// <summary>
        /// Enum TXT for value: TXT
        /// </summary>
        [EnumMember(Value = "TXT")]
        TXT = 2

    }

}