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
    /// Defines ProvisioningGroupsAction
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProvisioningGroupsAction
    {
        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 1,

        /// <summary>
        /// Enum APPEND for value: APPEND
        /// </summary>
        [EnumMember(Value = "APPEND")]
        APPEND = 2,

        /// <summary>
        /// Enum SYNC for value: SYNC
        /// </summary>
        [EnumMember(Value = "SYNC")]
        SYNC = 3,

        /// <summary>
        /// Enum ASSIGN for value: ASSIGN
        /// </summary>
        [EnumMember(Value = "ASSIGN")]
        ASSIGN = 4

    }

}
