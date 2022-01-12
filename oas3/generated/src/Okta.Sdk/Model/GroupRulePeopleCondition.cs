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
    /// GroupRulePeopleCondition
    /// </summary>
    [DataContract]
        public partial class GroupRulePeopleCondition :  IEquatable<GroupRulePeopleCondition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRulePeopleCondition" /> class.
        /// </summary>
        /// <param name="groups">groups.</param>
        /// <param name="users">users.</param>
        public GroupRulePeopleCondition(GroupRuleGroupCondition groups = default(GroupRuleGroupCondition), GroupRuleUserCondition users = default(GroupRuleUserCondition))
        {
            this.Groups = groups;
            this.Users = users;
        }
        
        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public GroupRuleGroupCondition Groups { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public GroupRuleUserCondition Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupRulePeopleCondition {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as GroupRulePeopleCondition);
        }

        /// <summary>
        /// Returns true if GroupRulePeopleCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupRulePeopleCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupRulePeopleCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Groups == input.Groups ||
                    (this.Groups != null &&
                    this.Groups.Equals(input.Groups))
                ) && 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.Equals(input.Users))
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
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }
    }
}
