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
    /// MDMEnrollmentPolicyRuleCondition
    /// </summary>
    [DataContract]
        public partial class MDMEnrollmentPolicyRuleCondition :  IEquatable<MDMEnrollmentPolicyRuleCondition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MDMEnrollmentPolicyRuleCondition" /> class.
        /// </summary>
        /// <param name="blockNonSafeAndroid">blockNonSafeAndroid.</param>
        /// <param name="enrollment">enrollment.</param>
        public MDMEnrollmentPolicyRuleCondition(bool? blockNonSafeAndroid = default(bool?), MDMEnrollmentPolicyEnrollment enrollment = default(MDMEnrollmentPolicyEnrollment))
        {
            this.BlockNonSafeAndroid = blockNonSafeAndroid;
            this.Enrollment = enrollment;
        }
        
        /// <summary>
        /// Gets or Sets BlockNonSafeAndroid
        /// </summary>
        [DataMember(Name="blockNonSafeAndroid", EmitDefaultValue=false)]
        public bool? BlockNonSafeAndroid { get; set; }

        /// <summary>
        /// Gets or Sets Enrollment
        /// </summary>
        [DataMember(Name="enrollment", EmitDefaultValue=false)]
        public MDMEnrollmentPolicyEnrollment Enrollment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MDMEnrollmentPolicyRuleCondition {\n");
            sb.Append("  BlockNonSafeAndroid: ").Append(BlockNonSafeAndroid).Append("\n");
            sb.Append("  Enrollment: ").Append(Enrollment).Append("\n");
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
            return this.Equals(input as MDMEnrollmentPolicyRuleCondition);
        }

        /// <summary>
        /// Returns true if MDMEnrollmentPolicyRuleCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of MDMEnrollmentPolicyRuleCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MDMEnrollmentPolicyRuleCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlockNonSafeAndroid == input.BlockNonSafeAndroid ||
                    (this.BlockNonSafeAndroid != null &&
                    this.BlockNonSafeAndroid.Equals(input.BlockNonSafeAndroid))
                ) && 
                (
                    this.Enrollment == input.Enrollment ||
                    (this.Enrollment != null &&
                    this.Enrollment.Equals(input.Enrollment))
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
                if (this.BlockNonSafeAndroid != null)
                    hashCode = hashCode * 59 + this.BlockNonSafeAndroid.GetHashCode();
                if (this.Enrollment != null)
                    hashCode = hashCode * 59 + this.Enrollment.GetHashCode();
                return hashCode;
            }
        }
    }
}
