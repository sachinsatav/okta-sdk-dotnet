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
    /// Csr
    /// </summary>
    [DataContract]
        public partial class Csr :  IEquatable<Csr>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Csr" /> class.
        /// </summary>
        public Csr()
        {
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; private set; }

        /// <summary>
        /// Gets or Sets _Csr
        /// </summary>
        [DataMember(Name="csr", EmitDefaultValue=false)]
        public string _Csr { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets Kty
        /// </summary>
        [DataMember(Name="kty", EmitDefaultValue=false)]
        public string Kty { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Csr {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  _Csr: ").Append(_Csr).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Kty: ").Append(Kty).Append("\n");
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
            return this.Equals(input as Csr);
        }

        /// <summary>
        /// Returns true if Csr instances are equal
        /// </summary>
        /// <param name="input">Instance of Csr to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Csr input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this._Csr == input._Csr ||
                    (this._Csr != null &&
                    this._Csr.Equals(input._Csr))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Kty == input.Kty ||
                    (this.Kty != null &&
                    this.Kty.Equals(input.Kty))
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this._Csr != null)
                    hashCode = hashCode * 59 + this._Csr.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Kty != null)
                    hashCode = hashCode * 59 + this.Kty.GetHashCode();
                return hashCode;
            }
        }
    }
}
