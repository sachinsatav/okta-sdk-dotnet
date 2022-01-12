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
    /// ProtocolAlgorithmType
    /// </summary>
    [DataContract]
        public partial class ProtocolAlgorithmType :  IEquatable<ProtocolAlgorithmType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtocolAlgorithmType" /> class.
        /// </summary>
        /// <param name="signature">signature.</param>
        public ProtocolAlgorithmType(ProtocolAlgorithmTypeSignature signature = default(ProtocolAlgorithmTypeSignature))
        {
            this.Signature = signature;
        }
        
        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public ProtocolAlgorithmTypeSignature Signature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtocolAlgorithmType {\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as ProtocolAlgorithmType);
        }

        /// <summary>
        /// Returns true if ProtocolAlgorithmType instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtocolAlgorithmType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtocolAlgorithmType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
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
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                return hashCode;
            }
        }
    }
}
