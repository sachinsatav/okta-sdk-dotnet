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
    /// Defines NotificationType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationType
    {
        /// <summary>
        /// Enum CONNECTORAGENT for value: CONNECTOR_AGENT
        /// </summary>
        [EnumMember(Value = "CONNECTOR_AGENT")]
        CONNECTORAGENT = 1,

        /// <summary>
        /// Enum USERLOCKEDOUT for value: USER_LOCKED_OUT
        /// </summary>
        [EnumMember(Value = "USER_LOCKED_OUT")]
        USERLOCKEDOUT = 2,

        /// <summary>
        /// Enum APPIMPORT for value: APP_IMPORT
        /// </summary>
        [EnumMember(Value = "APP_IMPORT")]
        APPIMPORT = 3,

        /// <summary>
        /// Enum LDAPAGENT for value: LDAP_AGENT
        /// </summary>
        [EnumMember(Value = "LDAP_AGENT")]
        LDAPAGENT = 4,

        /// <summary>
        /// Enum ADAGENT for value: AD_AGENT
        /// </summary>
        [EnumMember(Value = "AD_AGENT")]
        ADAGENT = 5,

        /// <summary>
        /// Enum OKTAANNOUNCEMENT for value: OKTA_ANNOUNCEMENT
        /// </summary>
        [EnumMember(Value = "OKTA_ANNOUNCEMENT")]
        OKTAANNOUNCEMENT = 6,

        /// <summary>
        /// Enum OKTAISSUE for value: OKTA_ISSUE
        /// </summary>
        [EnumMember(Value = "OKTA_ISSUE")]
        OKTAISSUE = 7,

        /// <summary>
        /// Enum OKTAUPDATE for value: OKTA_UPDATE
        /// </summary>
        [EnumMember(Value = "OKTA_UPDATE")]
        OKTAUPDATE = 8,

        /// <summary>
        /// Enum IWAAGENT for value: IWA_AGENT
        /// </summary>
        [EnumMember(Value = "IWA_AGENT")]
        IWAAGENT = 9,

        /// <summary>
        /// Enum USERDEPROVISION for value: USER_DEPROVISION
        /// </summary>
        [EnumMember(Value = "USER_DEPROVISION")]
        USERDEPROVISION = 10,

        /// <summary>
        /// Enum REPORTSUSPICIOUSACTIVITY for value: REPORT_SUSPICIOUS_ACTIVITY
        /// </summary>
        [EnumMember(Value = "REPORT_SUSPICIOUS_ACTIVITY")]
        REPORTSUSPICIOUSACTIVITY = 11,

        /// <summary>
        /// Enum RATELIMITNOTIFICATION for value: RATELIMIT_NOTIFICATION
        /// </summary>
        [EnumMember(Value = "RATELIMIT_NOTIFICATION")]
        RATELIMITNOTIFICATION = 12

    }

}
