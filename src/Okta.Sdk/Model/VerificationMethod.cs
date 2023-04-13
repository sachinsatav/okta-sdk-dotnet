/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 3.0.0
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
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// VerificationMethod
    /// </summary>
    [DataContract(Name = "VerificationMethod")]
    
    public partial class VerificationMethod : IEquatable<VerificationMethod>
    {
        
        /// <summary>
        /// Gets or Sets Constraints
        /// </summary>
        [DataMember(Name = "constraints", EmitDefaultValue = false)]
        public List<AccessPolicyConstraints> Constraints { get; set; }

        /// <summary>
        /// Gets or Sets FactorMode
        /// </summary>
        [DataMember(Name = "factorMode", EmitDefaultValue = false)]
        public string FactorMode { get; set; }

        /// <summary>
        /// Gets or Sets ReauthenticateIn
        /// </summary>
        [DataMember(Name = "reauthenticateIn", EmitDefaultValue = false)]
        public string ReauthenticateIn { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerificationMethod {\n");
            sb.Append("  Constraints: ").Append(Constraints).Append("\n");
            sb.Append("  FactorMode: ").Append(FactorMode).Append("\n");
            sb.Append("  ReauthenticateIn: ").Append(ReauthenticateIn).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as VerificationMethod);
        }

        /// <summary>
        /// Returns true if VerificationMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of VerificationMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerificationMethod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Constraints == input.Constraints ||
                    this.Constraints != null &&
                    input.Constraints != null &&
                    this.Constraints.SequenceEqual(input.Constraints)
                ) && 
                (
                    this.FactorMode == input.FactorMode ||
                    (this.FactorMode != null &&
                    this.FactorMode.Equals(input.FactorMode))
                ) && 
                (
                    this.ReauthenticateIn == input.ReauthenticateIn ||
                    (this.ReauthenticateIn != null &&
                    this.ReauthenticateIn.Equals(input.ReauthenticateIn))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                
                if (this.Constraints != null)
                {
                    hashCode = (hashCode * 59) + this.Constraints.GetHashCode();
                }
                if (this.FactorMode != null)
                {
                    hashCode = (hashCode * 59) + this.FactorMode.GetHashCode();
                }
                if (this.ReauthenticateIn != null)
                {
                    hashCode = (hashCode * 59) + this.ReauthenticateIn.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}