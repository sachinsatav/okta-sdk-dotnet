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
    /// GroupRuleAction
    /// </summary>
    [DataContract(Name = "GroupRuleAction")]
    public partial class GroupRuleAction : IEquatable<GroupRuleAction>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets AssignUserToGroups
        /// </summary>
        [DataMember(Name = "assignUserToGroups", EmitDefaultValue = false)]
        public GroupRuleGroupAssignment AssignUserToGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupRuleAction {\n");
            sb.Append("  AssignUserToGroups: ").Append(AssignUserToGroups).Append("\n");
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
            return this.Equals(input as GroupRuleAction);
        }

        /// <summary>
        /// Returns true if GroupRuleAction instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupRuleAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupRuleAction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssignUserToGroups == input.AssignUserToGroups ||
                    (this.AssignUserToGroups != null &&
                    this.AssignUserToGroups.Equals(input.AssignUserToGroups))
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
                if (this.AssignUserToGroups != null)
                {
                    hashCode = (hashCode * 59) + this.AssignUserToGroups.GetHashCode();
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
