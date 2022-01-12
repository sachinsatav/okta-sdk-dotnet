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
    /// LinkedObject
    /// </summary>
    [DataContract]
        public partial class LinkedObject :  IEquatable<LinkedObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedObject" /> class.
        /// </summary>
        /// <param name="associated">associated.</param>
        /// <param name="primary">primary.</param>
        public LinkedObject(LinkedObjectDetails associated = default(LinkedObjectDetails), LinkedObjectDetails primary = default(LinkedObjectDetails))
        {
            this.Associated = associated;
            this.Primary = primary;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public Dictionary<string, Object> Links { get; private set; }

        /// <summary>
        /// Gets or Sets Associated
        /// </summary>
        [DataMember(Name="associated", EmitDefaultValue=false)]
        public LinkedObjectDetails Associated { get; set; }

        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public LinkedObjectDetails Primary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkedObject {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Associated: ").Append(Associated).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
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
            return this.Equals(input as LinkedObject);
        }

        /// <summary>
        /// Returns true if LinkedObject instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkedObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkedObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Associated == input.Associated ||
                    (this.Associated != null &&
                    this.Associated.Equals(input.Associated))
                ) && 
                (
                    this.Primary == input.Primary ||
                    (this.Primary != null &&
                    this.Primary.Equals(input.Primary))
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Associated != null)
                    hashCode = hashCode * 59 + this.Associated.GetHashCode();
                if (this.Primary != null)
                    hashCode = hashCode * 59 + this.Primary.GetHashCode();
                return hashCode;
            }
        }
    }
}
