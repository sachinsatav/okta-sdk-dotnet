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
    /// PasswordPolicyPasswordSettingsLockout
    /// </summary>
    [DataContract]
        public partial class PasswordPolicyPasswordSettingsLockout :  IEquatable<PasswordPolicyPasswordSettingsLockout>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyPasswordSettingsLockout" /> class.
        /// </summary>
        /// <param name="autoUnlockMinutes">autoUnlockMinutes.</param>
        /// <param name="maxAttempts">maxAttempts.</param>
        /// <param name="showLockoutFailures">showLockoutFailures.</param>
        /// <param name="userLockoutNotificationChannels">userLockoutNotificationChannels.</param>
        public PasswordPolicyPasswordSettingsLockout(int? autoUnlockMinutes = default(int?), int? maxAttempts = default(int?), bool? showLockoutFailures = default(bool?), List<string> userLockoutNotificationChannels = default(List<string>))
        {
            this.AutoUnlockMinutes = autoUnlockMinutes;
            this.MaxAttempts = maxAttempts;
            this.ShowLockoutFailures = showLockoutFailures;
            this.UserLockoutNotificationChannels = userLockoutNotificationChannels;
        }
        
        /// <summary>
        /// Gets or Sets AutoUnlockMinutes
        /// </summary>
        [DataMember(Name="autoUnlockMinutes", EmitDefaultValue=false)]
        public int? AutoUnlockMinutes { get; set; }

        /// <summary>
        /// Gets or Sets MaxAttempts
        /// </summary>
        [DataMember(Name="maxAttempts", EmitDefaultValue=false)]
        public int? MaxAttempts { get; set; }

        /// <summary>
        /// Gets or Sets ShowLockoutFailures
        /// </summary>
        [DataMember(Name="showLockoutFailures", EmitDefaultValue=false)]
        public bool? ShowLockoutFailures { get; set; }

        /// <summary>
        /// Gets or Sets UserLockoutNotificationChannels
        /// </summary>
        [DataMember(Name="userLockoutNotificationChannels", EmitDefaultValue=false)]
        public List<string> UserLockoutNotificationChannels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordPolicyPasswordSettingsLockout {\n");
            sb.Append("  AutoUnlockMinutes: ").Append(AutoUnlockMinutes).Append("\n");
            sb.Append("  MaxAttempts: ").Append(MaxAttempts).Append("\n");
            sb.Append("  ShowLockoutFailures: ").Append(ShowLockoutFailures).Append("\n");
            sb.Append("  UserLockoutNotificationChannels: ").Append(UserLockoutNotificationChannels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PasswordPolicyPasswordSettingsLockout);
        }

        /// <summary>
        /// Returns true if PasswordPolicyPasswordSettingsLockout instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyPasswordSettingsLockout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyPasswordSettingsLockout input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoUnlockMinutes == input.AutoUnlockMinutes ||
                    (this.AutoUnlockMinutes != null &&
                    this.AutoUnlockMinutes.Equals(input.AutoUnlockMinutes))
                ) && 
                (
                    this.MaxAttempts == input.MaxAttempts ||
                    (this.MaxAttempts != null &&
                    this.MaxAttempts.Equals(input.MaxAttempts))
                ) && 
                (
                    this.ShowLockoutFailures == input.ShowLockoutFailures ||
                    (this.ShowLockoutFailures != null &&
                    this.ShowLockoutFailures.Equals(input.ShowLockoutFailures))
                ) && 
                (
                    this.UserLockoutNotificationChannels == input.UserLockoutNotificationChannels ||
                    this.UserLockoutNotificationChannels != null &&
                    input.UserLockoutNotificationChannels != null &&
                    this.UserLockoutNotificationChannels.SequenceEqual(input.UserLockoutNotificationChannels)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AutoUnlockMinutes != null)
                    hashCode = hashCode * 59 + this.AutoUnlockMinutes.GetHashCode();
                if (this.MaxAttempts != null)
                    hashCode = hashCode * 59 + this.MaxAttempts.GetHashCode();
                if (this.ShowLockoutFailures != null)
                    hashCode = hashCode * 59 + this.ShowLockoutFailures.GetHashCode();
                if (this.UserLockoutNotificationChannels != null)
                    hashCode = hashCode * 59 + this.UserLockoutNotificationChannels.GetHashCode();
                return hashCode;
            }
        }
    }
}
