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
    /// Defines PolicyUserStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PolicyUserStatus
    {
        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 1,

        /// <summary>
        /// Enum INACTIVE for value: INACTIVE
        /// </summary>
        [EnumMember(Value = "INACTIVE")]
        INACTIVE = 2,

        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING = 3,

        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED = 4,

        /// <summary>
        /// Enum EXPIREDPASSWORD for value: EXPIRED_PASSWORD
        /// </summary>
        [EnumMember(Value = "EXPIRED_PASSWORD")]
        EXPIREDPASSWORD = 5,

        /// <summary>
        /// Enum ACTIVATING for value: ACTIVATING
        /// </summary>
        [EnumMember(Value = "ACTIVATING")]
        ACTIVATING = 6,

        /// <summary>
        /// Enum SUSPENDED for value: SUSPENDED
        /// </summary>
        [EnumMember(Value = "SUSPENDED")]
        SUSPENDED = 7,

        /// <summary>
        /// Enum DELETING for value: DELETING
        /// </summary>
        [EnumMember(Value = "DELETING")]
        DELETING = 8

    }

}
