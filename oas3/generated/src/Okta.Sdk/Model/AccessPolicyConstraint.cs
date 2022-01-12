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
    /// AccessPolicyConstraint
    /// </summary>
    [DataContract]
        public partial class AccessPolicyConstraint :  IEquatable<AccessPolicyConstraint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPolicyConstraint" /> class.
        /// </summary>
        /// <param name="methods">methods.</param>
        /// <param name="reauthenticateIn">reauthenticateIn.</param>
        /// <param name="types">types.</param>
        public AccessPolicyConstraint(List<string> methods = default(List<string>), string reauthenticateIn = default(string), List<string> types = default(List<string>))
        {
            this.Methods = methods;
            this.ReauthenticateIn = reauthenticateIn;
            this.Types = types;
        }
        
        /// <summary>
        /// Gets or Sets Methods
        /// </summary>
        [DataMember(Name="methods", EmitDefaultValue=false)]
        public List<string> Methods { get; set; }

        /// <summary>
        /// Gets or Sets ReauthenticateIn
        /// </summary>
        [DataMember(Name="reauthenticateIn", EmitDefaultValue=false)]
        public string ReauthenticateIn { get; set; }

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessPolicyConstraint {\n");
            sb.Append("  Methods: ").Append(Methods).Append("\n");
            sb.Append("  ReauthenticateIn: ").Append(ReauthenticateIn).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return this.Equals(input as AccessPolicyConstraint);
        }

        /// <summary>
        /// Returns true if AccessPolicyConstraint instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessPolicyConstraint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessPolicyConstraint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Methods == input.Methods ||
                    this.Methods != null &&
                    input.Methods != null &&
                    this.Methods.SequenceEqual(input.Methods)
                ) && 
                (
                    this.ReauthenticateIn == input.ReauthenticateIn ||
                    (this.ReauthenticateIn != null &&
                    this.ReauthenticateIn.Equals(input.ReauthenticateIn))
                ) && 
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    input.Types != null &&
                    this.Types.SequenceEqual(input.Types)
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
                if (this.Methods != null)
                    hashCode = hashCode * 59 + this.Methods.GetHashCode();
                if (this.ReauthenticateIn != null)
                    hashCode = hashCode * 59 + this.ReauthenticateIn.GetHashCode();
                if (this.Types != null)
                    hashCode = hashCode * 59 + this.Types.GetHashCode();
                return hashCode;
            }
        }
    }
}
