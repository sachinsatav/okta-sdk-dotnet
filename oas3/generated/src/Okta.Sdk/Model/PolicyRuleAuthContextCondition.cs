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
    /// PolicyRuleAuthContextCondition
    /// </summary>
    [DataContract]
        public partial class PolicyRuleAuthContextCondition :  IEquatable<PolicyRuleAuthContextCondition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyRuleAuthContextCondition" /> class.
        /// </summary>
        /// <param name="authType">authType.</param>
        public PolicyRuleAuthContextCondition(PolicyRuleAuthContextType authType = default(PolicyRuleAuthContextType))
        {
            this.AuthType = authType;
        }
        
        /// <summary>
        /// Gets or Sets AuthType
        /// </summary>
        [DataMember(Name="authType", EmitDefaultValue=false)]
        public PolicyRuleAuthContextType AuthType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyRuleAuthContextCondition {\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
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
            return this.Equals(input as PolicyRuleAuthContextCondition);
        }

        /// <summary>
        /// Returns true if PolicyRuleAuthContextCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyRuleAuthContextCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyRuleAuthContextCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
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
                if (this.AuthType != null)
                    hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                return hashCode;
            }
        }
    }
}
