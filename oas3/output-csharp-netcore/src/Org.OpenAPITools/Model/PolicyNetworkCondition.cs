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
    /// PolicyNetworkCondition
    /// </summary>
    [DataContract(Name = "PolicyNetworkCondition")]
    public partial class PolicyNetworkCondition : IEquatable<PolicyNetworkCondition>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Connection
        /// </summary>
        [DataMember(Name = "connection", EmitDefaultValue = false)]
        public PolicyNetworkConnection? Connection { get; set; }
        
        /// <summary>
        /// Gets or Sets Exclude
        /// </summary>
        [DataMember(Name = "exclude", EmitDefaultValue = false)]
        public List<string> Exclude { get; set; }

        /// <summary>
        /// Gets or Sets Include
        /// </summary>
        [DataMember(Name = "include", EmitDefaultValue = false)]
        public List<string> Include { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PolicyNetworkCondition {\n");
            sb.Append("  Connection: ").Append(Connection).Append("\n");
            sb.Append("  Exclude: ").Append(Exclude).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyNetworkCondition);
        }

        /// <summary>
        /// Returns true if PolicyNetworkCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyNetworkCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyNetworkCondition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Connection == input.Connection ||
                    this.Connection.Equals(input.Connection)
                ) && 
                (
                    this.Exclude == input.Exclude ||
                    this.Exclude != null &&
                    input.Exclude != null &&
                    this.Exclude.SequenceEqual(input.Exclude)
                ) && 
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
                hashCode = (hashCode * 59) + this.Connection.GetHashCode();
                if (this.Exclude != null)
                {
                    hashCode = (hashCode * 59) + this.Exclude.GetHashCode();
                }
                if (this.Include != null)
                {
                    hashCode = (hashCode * 59) + this.Include.GetHashCode();
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
