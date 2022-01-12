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
    /// Defines ApplicationCredentialsScheme
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationCredentialsScheme
    {
        /// <summary>
        /// Enum SHAREDUSERNAMEANDPASSWORD for value: SHARED_USERNAME_AND_PASSWORD
        /// </summary>
        [EnumMember(Value = "SHARED_USERNAME_AND_PASSWORD")]
        SHAREDUSERNAMEANDPASSWORD = 1,
        /// <summary>
        /// Enum EXTERNALPASSWORDSYNC for value: EXTERNAL_PASSWORD_SYNC
        /// </summary>
        [EnumMember(Value = "EXTERNAL_PASSWORD_SYNC")]
        EXTERNALPASSWORDSYNC = 2,
        /// <summary>
        /// Enum EDITUSERNAMEANDPASSWORD for value: EDIT_USERNAME_AND_PASSWORD
        /// </summary>
        [EnumMember(Value = "EDIT_USERNAME_AND_PASSWORD")]
        EDITUSERNAMEANDPASSWORD = 3,
        /// <summary>
        /// Enum EDITPASSWORDONLY for value: EDIT_PASSWORD_ONLY
        /// </summary>
        [EnumMember(Value = "EDIT_PASSWORD_ONLY")]
        EDITPASSWORDONLY = 4,
        /// <summary>
        /// Enum ADMINSETSCREDENTIALS for value: ADMIN_SETS_CREDENTIALS
        /// </summary>
        [EnumMember(Value = "ADMIN_SETS_CREDENTIALS")]
        ADMINSETSCREDENTIALS = 5    }
}
