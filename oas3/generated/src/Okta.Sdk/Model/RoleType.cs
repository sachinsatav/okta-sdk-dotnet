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
    /// Defines RoleType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleType
    {
        /// <summary>
        /// Enum SUPERADMIN for value: SUPER_ADMIN
        /// </summary>
        [EnumMember(Value = "SUPER_ADMIN")]
        SUPERADMIN = 1,
        /// <summary>
        /// Enum ORGADMIN for value: ORG_ADMIN
        /// </summary>
        [EnumMember(Value = "ORG_ADMIN")]
        ORGADMIN = 2,
        /// <summary>
        /// Enum APPADMIN for value: APP_ADMIN
        /// </summary>
        [EnumMember(Value = "APP_ADMIN")]
        APPADMIN = 3,
        /// <summary>
        /// Enum USERADMIN for value: USER_ADMIN
        /// </summary>
        [EnumMember(Value = "USER_ADMIN")]
        USERADMIN = 4,
        /// <summary>
        /// Enum HELPDESKADMIN for value: HELP_DESK_ADMIN
        /// </summary>
        [EnumMember(Value = "HELP_DESK_ADMIN")]
        HELPDESKADMIN = 5,
        /// <summary>
        /// Enum READONLYADMIN for value: READ_ONLY_ADMIN
        /// </summary>
        [EnumMember(Value = "READ_ONLY_ADMIN")]
        READONLYADMIN = 6,
        /// <summary>
        /// Enum MOBILEADMIN for value: MOBILE_ADMIN
        /// </summary>
        [EnumMember(Value = "MOBILE_ADMIN")]
        MOBILEADMIN = 7,
        /// <summary>
        /// Enum APIACCESSMANAGEMENTADMIN for value: API_ACCESS_MANAGEMENT_ADMIN
        /// </summary>
        [EnumMember(Value = "API_ACCESS_MANAGEMENT_ADMIN")]
        APIACCESSMANAGEMENTADMIN = 8,
        /// <summary>
        /// Enum REPORTADMIN for value: REPORT_ADMIN
        /// </summary>
        [EnumMember(Value = "REPORT_ADMIN")]
        REPORTADMIN = 9,
        /// <summary>
        /// Enum GROUPMEMBERSHIPADMIN for value: GROUP_MEMBERSHIP_ADMIN
        /// </summary>
        [EnumMember(Value = "GROUP_MEMBERSHIP_ADMIN")]
        GROUPMEMBERSHIPADMIN = 10    }
}
