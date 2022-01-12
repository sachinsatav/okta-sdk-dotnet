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
    /// OktaSignOnPolicyRuleSignonActions
    /// </summary>
    [DataContract]
        public partial class OktaSignOnPolicyRuleSignonActions :  IEquatable<OktaSignOnPolicyRuleSignonActions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OktaSignOnPolicyRuleSignonActions" /> class.
        /// </summary>
        /// <param name="access">access.</param>
        /// <param name="factorLifetime">factorLifetime.</param>
        /// <param name="factorPromptMode">factorPromptMode.</param>
        /// <param name="rememberDeviceByDefault">rememberDeviceByDefault (default to false).</param>
        /// <param name="requireFactor">requireFactor (default to false).</param>
        /// <param name="session">session.</param>
        public OktaSignOnPolicyRuleSignonActions(PolicyAccess access = default(PolicyAccess), int? factorLifetime = default(int?), OktaSignOnPolicyFactorPromptMode factorPromptMode = default(OktaSignOnPolicyFactorPromptMode), bool? rememberDeviceByDefault = false, bool? requireFactor = false, OktaSignOnPolicyRuleSignonSessionActions session = default(OktaSignOnPolicyRuleSignonSessionActions))
        {
            this.Access = access;
            this.FactorLifetime = factorLifetime;
            this.FactorPromptMode = factorPromptMode;
            // use default value if no "rememberDeviceByDefault" provided
            if (rememberDeviceByDefault == null)
            {
                this.RememberDeviceByDefault = false;
            }
            else
            {
                this.RememberDeviceByDefault = rememberDeviceByDefault;
            }
            // use default value if no "requireFactor" provided
            if (requireFactor == null)
            {
                this.RequireFactor = false;
            }
            else
            {
                this.RequireFactor = requireFactor;
            }
            this.Session = session;
        }
        
        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public PolicyAccess Access { get; set; }

        /// <summary>
        /// Gets or Sets FactorLifetime
        /// </summary>
        [DataMember(Name="factorLifetime", EmitDefaultValue=false)]
        public int? FactorLifetime { get; set; }

        /// <summary>
        /// Gets or Sets FactorPromptMode
        /// </summary>
        [DataMember(Name="factorPromptMode", EmitDefaultValue=false)]
        public OktaSignOnPolicyFactorPromptMode FactorPromptMode { get; set; }

        /// <summary>
        /// Gets or Sets RememberDeviceByDefault
        /// </summary>
        [DataMember(Name="rememberDeviceByDefault", EmitDefaultValue=false)]
        public bool? RememberDeviceByDefault { get; set; }

        /// <summary>
        /// Gets or Sets RequireFactor
        /// </summary>
        [DataMember(Name="requireFactor", EmitDefaultValue=false)]
        public bool? RequireFactor { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public OktaSignOnPolicyRuleSignonSessionActions Session { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OktaSignOnPolicyRuleSignonActions {\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  FactorLifetime: ").Append(FactorLifetime).Append("\n");
            sb.Append("  FactorPromptMode: ").Append(FactorPromptMode).Append("\n");
            sb.Append("  RememberDeviceByDefault: ").Append(RememberDeviceByDefault).Append("\n");
            sb.Append("  RequireFactor: ").Append(RequireFactor).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
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
            return this.Equals(input as OktaSignOnPolicyRuleSignonActions);
        }

        /// <summary>
        /// Returns true if OktaSignOnPolicyRuleSignonActions instances are equal
        /// </summary>
        /// <param name="input">Instance of OktaSignOnPolicyRuleSignonActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OktaSignOnPolicyRuleSignonActions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
                ) && 
                (
                    this.FactorLifetime == input.FactorLifetime ||
                    (this.FactorLifetime != null &&
                    this.FactorLifetime.Equals(input.FactorLifetime))
                ) && 
                (
                    this.FactorPromptMode == input.FactorPromptMode ||
                    (this.FactorPromptMode != null &&
                    this.FactorPromptMode.Equals(input.FactorPromptMode))
                ) && 
                (
                    this.RememberDeviceByDefault == input.RememberDeviceByDefault ||
                    (this.RememberDeviceByDefault != null &&
                    this.RememberDeviceByDefault.Equals(input.RememberDeviceByDefault))
                ) && 
                (
                    this.RequireFactor == input.RequireFactor ||
                    (this.RequireFactor != null &&
                    this.RequireFactor.Equals(input.RequireFactor))
                ) && 
                (
                    this.Session == input.Session ||
                    (this.Session != null &&
                    this.Session.Equals(input.Session))
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
                if (this.Access != null)
                    hashCode = hashCode * 59 + this.Access.GetHashCode();
                if (this.FactorLifetime != null)
                    hashCode = hashCode * 59 + this.FactorLifetime.GetHashCode();
                if (this.FactorPromptMode != null)
                    hashCode = hashCode * 59 + this.FactorPromptMode.GetHashCode();
                if (this.RememberDeviceByDefault != null)
                    hashCode = hashCode * 59 + this.RememberDeviceByDefault.GetHashCode();
                if (this.RequireFactor != null)
                    hashCode = hashCode * 59 + this.RequireFactor.GetHashCode();
                if (this.Session != null)
                    hashCode = hashCode * 59 + this.Session.GetHashCode();
                return hashCode;
            }
        }
    }
}
