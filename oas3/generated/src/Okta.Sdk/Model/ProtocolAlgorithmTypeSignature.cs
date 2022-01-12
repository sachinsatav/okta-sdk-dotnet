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
    /// ProtocolAlgorithmTypeSignature
    /// </summary>
    [DataContract]
        public partial class ProtocolAlgorithmTypeSignature :  IEquatable<ProtocolAlgorithmTypeSignature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtocolAlgorithmTypeSignature" /> class.
        /// </summary>
        /// <param name="algorithm">algorithm.</param>
        /// <param name="scope">scope.</param>
        public ProtocolAlgorithmTypeSignature(string algorithm = default(string), ProtocolAlgorithmTypeSignatureScope scope = default(ProtocolAlgorithmTypeSignatureScope))
        {
            this.Algorithm = algorithm;
            this.Scope = scope;
        }
        
        /// <summary>
        /// Gets or Sets Algorithm
        /// </summary>
        [DataMember(Name="algorithm", EmitDefaultValue=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public ProtocolAlgorithmTypeSignatureScope Scope { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtocolAlgorithmTypeSignature {\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(input as ProtocolAlgorithmTypeSignature);
        }

        /// <summary>
        /// Returns true if ProtocolAlgorithmTypeSignature instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtocolAlgorithmTypeSignature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtocolAlgorithmTypeSignature input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
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
                if (this.Algorithm != null)
                    hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                return hashCode;
            }
        }
    }
}
