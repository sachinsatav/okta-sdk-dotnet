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
    /// BeforeScheduledActionPolicyRuleCondition
    /// </summary>
    [DataContract]
        public partial class BeforeScheduledActionPolicyRuleCondition :  IEquatable<BeforeScheduledActionPolicyRuleCondition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeforeScheduledActionPolicyRuleCondition" /> class.
        /// </summary>
        /// <param name="duration">duration.</param>
        /// <param name="lifecycleAction">lifecycleAction.</param>
        public BeforeScheduledActionPolicyRuleCondition(Duration duration = default(Duration), ScheduledUserLifecycleAction lifecycleAction = default(ScheduledUserLifecycleAction))
        {
            this.Duration = duration;
            this.LifecycleAction = lifecycleAction;
        }
        
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public Duration Duration { get; set; }

        /// <summary>
        /// Gets or Sets LifecycleAction
        /// </summary>
        [DataMember(Name="lifecycleAction", EmitDefaultValue=false)]
        public ScheduledUserLifecycleAction LifecycleAction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeforeScheduledActionPolicyRuleCondition {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  LifecycleAction: ").Append(LifecycleAction).Append("\n");
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
            return this.Equals(input as BeforeScheduledActionPolicyRuleCondition);
        }

        /// <summary>
        /// Returns true if BeforeScheduledActionPolicyRuleCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of BeforeScheduledActionPolicyRuleCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeforeScheduledActionPolicyRuleCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.LifecycleAction == input.LifecycleAction ||
                    (this.LifecycleAction != null &&
                    this.LifecycleAction.Equals(input.LifecycleAction))
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
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.LifecycleAction != null)
                    hashCode = hashCode * 59 + this.LifecycleAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
