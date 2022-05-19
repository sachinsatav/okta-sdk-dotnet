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
    /// Defines UserSchemaAttributeMasterType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserSchemaAttributeMasterType
    {
        /// <summary>
        /// Enum PROFILEMASTER for value: PROFILE_MASTER
        /// </summary>
        [EnumMember(Value = "PROFILE_MASTER")]
        PROFILEMASTER = 1,

        /// <summary>
        /// Enum OKTA for value: OKTA
        /// </summary>
        [EnumMember(Value = "OKTA")]
        OKTA = 2,

        /// <summary>
        /// Enum OVERRIDE for value: OVERRIDE
        /// </summary>
        [EnumMember(Value = "OVERRIDE")]
        OVERRIDE = 3

    }

}
