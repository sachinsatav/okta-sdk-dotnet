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
    /// Template: ModelGeneric
    /// PasswordPolicyPasswordSettingsAge
    /// </summary>
    [DataContract(Name = "PasswordPolicyPasswordSettingsAge")]
    public partial class PasswordPolicyPasswordSettingsAge : IEquatable<PasswordPolicyPasswordSettingsAge>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets ExpireWarnDays
        /// </summary>
        [DataMember(Name = "expireWarnDays", EmitDefaultValue = false)]
        public int ExpireWarnDays { get; set; }

        /// <summary>
        /// Gets or Sets HistoryCount
        /// </summary>
        [DataMember(Name = "historyCount", EmitDefaultValue = false)]
        public int HistoryCount { get; set; }

        /// <summary>
        /// Gets or Sets MaxAgeDays
        /// </summary>
        [DataMember(Name = "maxAgeDays", EmitDefaultValue = false)]
        public int MaxAgeDays { get; set; }

        /// <summary>
        /// Gets or Sets MinAgeMinutes
        /// </summary>
        [DataMember(Name = "minAgeMinutes", EmitDefaultValue = false)]
        public int MinAgeMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordPolicyPasswordSettingsAge {\n");
            sb.Append("  ExpireWarnDays: ").Append(ExpireWarnDays).Append("\n");
            sb.Append("  HistoryCount: ").Append(HistoryCount).Append("\n");
            sb.Append("  MaxAgeDays: ").Append(MaxAgeDays).Append("\n");
            sb.Append("  MinAgeMinutes: ").Append(MinAgeMinutes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PasswordPolicyPasswordSettingsAge);
        }

        /// <summary>
        /// Returns true if PasswordPolicyPasswordSettingsAge instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyPasswordSettingsAge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyPasswordSettingsAge input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpireWarnDays == input.ExpireWarnDays ||
                    this.ExpireWarnDays.Equals(input.ExpireWarnDays)
                ) && 
                (
                    this.HistoryCount == input.HistoryCount ||
                    this.HistoryCount.Equals(input.HistoryCount)
                ) && 
                (
                    this.MaxAgeDays == input.MaxAgeDays ||
                    this.MaxAgeDays.Equals(input.MaxAgeDays)
                ) && 
                (
                    this.MinAgeMinutes == input.MinAgeMinutes ||
                    this.MinAgeMinutes.Equals(input.MinAgeMinutes)
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
                hashCode = (hashCode * 59) + this.ExpireWarnDays.GetHashCode();
                hashCode = (hashCode * 59) + this.HistoryCount.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxAgeDays.GetHashCode();
                hashCode = (hashCode * 59) + this.MinAgeMinutes.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
