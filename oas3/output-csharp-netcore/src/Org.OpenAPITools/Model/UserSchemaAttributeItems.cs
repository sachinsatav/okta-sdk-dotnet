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
    /// UserSchemaAttributeItems
    /// </summary>
    [DataContract(Name = "UserSchemaAttributeItems")]
    public partial class UserSchemaAttributeItems : IEquatable<UserSchemaAttributeItems>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets Enum
        /// </summary>
        [DataMember(Name = "enum", EmitDefaultValue = false)]
        public List<string> Enum { get; set; }

        /// <summary>
        /// Gets or Sets OneOf
        /// </summary>
        [DataMember(Name = "oneOf", EmitDefaultValue = false)]
        public List<UserSchemaAttributeEnum> OneOf { get; set; }

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
            sb.Append("class UserSchemaAttributeItems {\n");
            sb.Append("  Enum: ").Append(Enum).Append("\n");
            sb.Append("  OneOf: ").Append(OneOf).Append("\n");
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
            return this.Equals(input as UserSchemaAttributeItems);
        }

        /// <summary>
        /// Returns true if UserSchemaAttributeItems instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSchemaAttributeItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSchemaAttributeItems input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enum == input.Enum ||
                    this.Enum != null &&
                    input.Enum != null &&
                    this.Enum.SequenceEqual(input.Enum)
                ) && 
                (
                    this.OneOf == input.OneOf ||
                    this.OneOf != null &&
                    input.OneOf != null &&
                    this.OneOf.SequenceEqual(input.OneOf)
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
                if (this.Enum != null)
                {
                    hashCode = (hashCode * 59) + this.Enum.GetHashCode();
                }
                if (this.OneOf != null)
                {
                    hashCode = (hashCode * 59) + this.OneOf.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
