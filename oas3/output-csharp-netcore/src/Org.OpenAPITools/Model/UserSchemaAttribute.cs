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
    /// UserSchemaAttribute
    /// </summary>
    [DataContract(Name = "UserSchemaAttribute")]
    public partial class UserSchemaAttribute : IEquatable<UserSchemaAttribute>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public UserSchemaAttributeType? Type { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public UserSchemaAttributeScope? Scope { get; set; }

        /// <summary>
        /// Gets or Sets Union
        /// </summary>
        [DataMember(Name = "union", EmitDefaultValue = false)]
        public UserSchemaAttributeUnion? Union { get; set; }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or Sets Mutability
        /// </summary>
        [DataMember(Name = "mutability", EmitDefaultValue = false)]
        public string Mutability { get; set; }

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
        /// Gets or Sets MinLength
        /// </summary>
        [DataMember(Name = "minLength", EmitDefaultValue = false)]
        public int MinLength { get; set; }

        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name = "maxLength", EmitDefaultValue = false)]
        public int MaxLength { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public List<UserSchemaAttributePermission> Permissions { get; set; }

        /// <summary>
        /// Gets or Sets Master
        /// </summary>
        [DataMember(Name = "master", EmitDefaultValue = false)]
        public UserSchemaAttributeMaster Master { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public UserSchemaAttributeItems Items { get; set; }

        /// <summary>
        /// Gets or Sets Pattern
        /// </summary>
        [DataMember(Name = "pattern", EmitDefaultValue = false)]
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or Sets Unique
        /// </summary>
        [DataMember(Name = "unique", EmitDefaultValue = false)]
        public string Unique { get; set; }

        /// <summary>
        /// Gets or Sets ExternalName
        /// </summary>
        [DataMember(Name = "externalName", EmitDefaultValue = false)]
        public string ExternalName { get; set; }

        /// <summary>
        /// Gets or Sets ExternalNamespace
        /// </summary>
        [DataMember(Name = "externalNamespace", EmitDefaultValue = false)]
        public string ExternalNamespace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSchemaAttribute {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Mutability: ").Append(Mutability).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Enum: ").Append(Enum).Append("\n");
            sb.Append("  OneOf: ").Append(OneOf).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Master: ").Append(Master).Append("\n");
            sb.Append("  Union: ").Append(Union).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  Unique: ").Append(Unique).Append("\n");
            sb.Append("  ExternalName: ").Append(ExternalName).Append("\n");
            sb.Append("  ExternalNamespace: ").Append(ExternalNamespace).Append("\n");
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
            return this.Equals(input as UserSchemaAttribute);
        }

        /// <summary>
        /// Returns true if UserSchemaAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSchemaAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSchemaAttribute input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.Mutability == input.Mutability ||
                    (this.Mutability != null &&
                    this.Mutability.Equals(input.Mutability))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
                ) && 
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
                    this.MinLength == input.MinLength ||
                    this.MinLength.Equals(input.MinLength)
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    this.MaxLength.Equals(input.MaxLength)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.Master == input.Master ||
                    (this.Master != null &&
                    this.Master.Equals(input.Master))
                ) && 
                (
                    this.Union == input.Union ||
                    this.Union.Equals(input.Union)
                ) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
                ) && 
                (
                    this.Pattern == input.Pattern ||
                    (this.Pattern != null &&
                    this.Pattern.Equals(input.Pattern))
                ) && 
                (
                    this.Unique == input.Unique ||
                    (this.Unique != null &&
                    this.Unique.Equals(input.Unique))
                ) && 
                (
                    this.ExternalName == input.ExternalName ||
                    (this.ExternalName != null &&
                    this.ExternalName.Equals(input.ExternalName))
                ) && 
                (
                    this.ExternalNamespace == input.ExternalNamespace ||
                    (this.ExternalNamespace != null &&
                    this.ExternalNamespace.Equals(input.ExternalNamespace))
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Required.GetHashCode();
                if (this.Mutability != null)
                {
                    hashCode = (hashCode * 59) + this.Mutability.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                if (this.Enum != null)
                {
                    hashCode = (hashCode * 59) + this.Enum.GetHashCode();
                }
                if (this.OneOf != null)
                {
                    hashCode = (hashCode * 59) + this.OneOf.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinLength.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxLength.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Permissions != null)
                {
                    hashCode = (hashCode * 59) + this.Permissions.GetHashCode();
                }
                if (this.Master != null)
                {
                    hashCode = (hashCode * 59) + this.Master.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Union.GetHashCode();
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                if (this.Pattern != null)
                {
                    hashCode = (hashCode * 59) + this.Pattern.GetHashCode();
                }
                if (this.Unique != null)
                {
                    hashCode = (hashCode * 59) + this.Unique.GetHashCode();
                }
                if (this.ExternalName != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalName.GetHashCode();
                }
                if (this.ExternalNamespace != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalNamespace.GetHashCode();
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
