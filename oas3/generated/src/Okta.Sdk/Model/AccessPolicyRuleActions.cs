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
    /// AccessPolicyRuleActions
    /// </summary>
    [DataContract]
        public partial class AccessPolicyRuleActions :  IEquatable<AccessPolicyRuleActions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicyRuleActions" /> class.
        /// </summary>
        /// <param name="appSignOn">appSignOn.</param>
        public AccessPolicyRuleActions(AccessPolicyRuleApplicationSignOn appSignOn = default(AccessPolicyRuleApplicationSignOn))
        {
            this.AppSignOn = appSignOn;
        }
        
        /// <summary>
        /// Gets or Sets AppSignOn
        /// </summary>
        [DataMember(Name="appSignOn", EmitDefaultValue=false)]
        public AccessPolicyRuleApplicationSignOn AppSignOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessPolicyRuleActions {\n");
            sb.Append("  AppSignOn: ").Append(AppSignOn).Append("\n");
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
            return this.Equals(input as AccessPolicyRuleActions);
        }

        /// <summary>
        /// Returns true if AccessPolicyRuleActions instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessPolicyRuleActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessPolicyRuleActions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppSignOn == input.AppSignOn ||
                    (this.AppSignOn != null &&
                    this.AppSignOn.Equals(input.AppSignOn))
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
                if (this.AppSignOn != null)
                    hashCode = hashCode * 59 + this.AppSignOn.GetHashCode();
                return hashCode;
            }
        }
    }
}
