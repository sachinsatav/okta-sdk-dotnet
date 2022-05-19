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
    /// SwaThreeFieldApplicationSettingsApplicationAllOf
    /// </summary>
    [DataContract(Name = "SwaThreeFieldApplicationSettingsApplication_allOf")]
    public partial class SwaThreeFieldApplicationSettingsApplicationAllOf : IEquatable<SwaThreeFieldApplicationSettingsApplicationAllOf>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets ButtonSelector
        /// </summary>
        [DataMember(Name = "buttonSelector", EmitDefaultValue = false)]
        public string ButtonSelector { get; set; }

        /// <summary>
        /// Gets or Sets ExtraFieldSelector
        /// </summary>
        [DataMember(Name = "extraFieldSelector", EmitDefaultValue = false)]
        public string ExtraFieldSelector { get; set; }

        /// <summary>
        /// Gets or Sets ExtraFieldValue
        /// </summary>
        [DataMember(Name = "extraFieldValue", EmitDefaultValue = false)]
        public string ExtraFieldValue { get; set; }

        /// <summary>
        /// Gets or Sets LoginUrlRegex
        /// </summary>
        [DataMember(Name = "loginUrlRegex", EmitDefaultValue = false)]
        public string LoginUrlRegex { get; set; }

        /// <summary>
        /// Gets or Sets PasswordSelector
        /// </summary>
        [DataMember(Name = "passwordSelector", EmitDefaultValue = false)]
        public string PasswordSelector { get; set; }

        /// <summary>
        /// Gets or Sets TargetURL
        /// </summary>
        [DataMember(Name = "targetURL", EmitDefaultValue = false)]
        public string TargetURL { get; set; }

        /// <summary>
        /// Gets or Sets UserNameSelector
        /// </summary>
        [DataMember(Name = "userNameSelector", EmitDefaultValue = false)]
        public string UserNameSelector { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SwaThreeFieldApplicationSettingsApplicationAllOf {\n");
            sb.Append("  ButtonSelector: ").Append(ButtonSelector).Append("\n");
            sb.Append("  ExtraFieldSelector: ").Append(ExtraFieldSelector).Append("\n");
            sb.Append("  ExtraFieldValue: ").Append(ExtraFieldValue).Append("\n");
            sb.Append("  LoginUrlRegex: ").Append(LoginUrlRegex).Append("\n");
            sb.Append("  PasswordSelector: ").Append(PasswordSelector).Append("\n");
            sb.Append("  TargetURL: ").Append(TargetURL).Append("\n");
            sb.Append("  UserNameSelector: ").Append(UserNameSelector).Append("\n");
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
            return this.Equals(input as SwaThreeFieldApplicationSettingsApplicationAllOf);
        }

        /// <summary>
        /// Returns true if SwaThreeFieldApplicationSettingsApplicationAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of SwaThreeFieldApplicationSettingsApplicationAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwaThreeFieldApplicationSettingsApplicationAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ButtonSelector == input.ButtonSelector ||
                    (this.ButtonSelector != null &&
                    this.ButtonSelector.Equals(input.ButtonSelector))
                ) && 
                (
                    this.ExtraFieldSelector == input.ExtraFieldSelector ||
                    (this.ExtraFieldSelector != null &&
                    this.ExtraFieldSelector.Equals(input.ExtraFieldSelector))
                ) && 
                (
                    this.ExtraFieldValue == input.ExtraFieldValue ||
                    (this.ExtraFieldValue != null &&
                    this.ExtraFieldValue.Equals(input.ExtraFieldValue))
                ) && 
                (
                    this.LoginUrlRegex == input.LoginUrlRegex ||
                    (this.LoginUrlRegex != null &&
                    this.LoginUrlRegex.Equals(input.LoginUrlRegex))
                ) && 
                (
                    this.PasswordSelector == input.PasswordSelector ||
                    (this.PasswordSelector != null &&
                    this.PasswordSelector.Equals(input.PasswordSelector))
                ) && 
                (
                    this.TargetURL == input.TargetURL ||
                    (this.TargetURL != null &&
                    this.TargetURL.Equals(input.TargetURL))
                ) && 
                (
                    this.UserNameSelector == input.UserNameSelector ||
                    (this.UserNameSelector != null &&
                    this.UserNameSelector.Equals(input.UserNameSelector))
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
                if (this.ButtonSelector != null)
                {
                    hashCode = (hashCode * 59) + this.ButtonSelector.GetHashCode();
                }
                if (this.ExtraFieldSelector != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraFieldSelector.GetHashCode();
                }
                if (this.ExtraFieldValue != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraFieldValue.GetHashCode();
                }
                if (this.LoginUrlRegex != null)
                {
                    hashCode = (hashCode * 59) + this.LoginUrlRegex.GetHashCode();
                }
                if (this.PasswordSelector != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordSelector.GetHashCode();
                }
                if (this.TargetURL != null)
                {
                    hashCode = (hashCode * 59) + this.TargetURL.GetHashCode();
                }
                if (this.UserNameSelector != null)
                {
                    hashCode = (hashCode * 59) + this.UserNameSelector.GetHashCode();
                }
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
