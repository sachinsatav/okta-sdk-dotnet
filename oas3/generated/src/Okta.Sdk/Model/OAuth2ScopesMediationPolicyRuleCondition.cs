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
    /// OAuth2ScopesMediationPolicyRuleCondition
    /// </summary>
    [DataContract]
        public partial class OAuth2ScopesMediationPolicyRuleCondition :  IEquatable<OAuth2ScopesMediationPolicyRuleCondition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2ScopesMediationPolicyRuleCondition" /> class.
        /// </summary>
        /// <param name="include">include.</param>
        public OAuth2ScopesMediationPolicyRuleCondition(List<string> include = default(List<string>))
        {
            this.Include = include;
        }
        
        /// <summary>
        /// Gets or Sets Include
        /// </summary>
        [DataMember(Name="include", EmitDefaultValue=false)]
        public List<string> Include { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuth2ScopesMediationPolicyRuleCondition {\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
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
            return this.Equals(input as OAuth2ScopesMediationPolicyRuleCondition);
        }

        /// <summary>
        /// Returns true if OAuth2ScopesMediationPolicyRuleCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuth2ScopesMediationPolicyRuleCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuth2ScopesMediationPolicyRuleCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Include == input.Include ||
                    this.Include != null &&
                    input.Include != null &&
                    this.Include.SequenceEqual(input.Include)
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
                if (this.Include != null)
                    hashCode = hashCode * 59 + this.Include.GetHashCode();
                return hashCode;
            }
        }
    }
}
