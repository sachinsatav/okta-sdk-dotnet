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
    /// Defines LogAuthenticationProvider
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LogAuthenticationProvider
    {
        /// <summary>
        /// Enum OKTAAUTHENTICATIONPROVIDER for value: OKTA_AUTHENTICATION_PROVIDER
        /// </summary>
        [EnumMember(Value = "OKTA_AUTHENTICATION_PROVIDER")]
        OKTAAUTHENTICATIONPROVIDER = 1,

        /// <summary>
        /// Enum ACTIVEDIRECTORY for value: ACTIVE_DIRECTORY
        /// </summary>
        [EnumMember(Value = "ACTIVE_DIRECTORY")]
        ACTIVEDIRECTORY = 2,

        /// <summary>
        /// Enum LDAP for value: LDAP
        /// </summary>
        [EnumMember(Value = "LDAP")]
        LDAP = 3,

        /// <summary>
        /// Enum FEDERATION for value: FEDERATION
        /// </summary>
        [EnumMember(Value = "FEDERATION")]
        FEDERATION = 4,

        /// <summary>
        /// Enum SOCIAL for value: SOCIAL
        /// </summary>
        [EnumMember(Value = "SOCIAL")]
        SOCIAL = 5,

        /// <summary>
        /// Enum FACTORPROVIDER for value: FACTOR_PROVIDER
        /// </summary>
        [EnumMember(Value = "FACTOR_PROVIDER")]
        FACTORPROVIDER = 6

    }

}
