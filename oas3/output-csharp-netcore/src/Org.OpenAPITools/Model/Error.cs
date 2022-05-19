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
    /// Error
    /// </summary>
    [DataContract(Name = "Error")]
    public partial class Error : IEquatable<Error>, IValidatableObject
    {
        
        /// <summary>
        /// An Okta code for this type of error
        /// </summary>
        /// <value>An Okta code for this type of error</value>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// A short description of what caused this error. Sometimes this contains dynamically-generated information about your specific error.
        /// </summary>
        /// <value>A short description of what caused this error. Sometimes this contains dynamically-generated information about your specific error.</value>
        [DataMember(Name = "errorSummary", EmitDefaultValue = false)]
        public string ErrorSummary { get; set; }

        /// <summary>
        /// An Okta code for this type of error
        /// </summary>
        /// <value>An Okta code for this type of error</value>
        [DataMember(Name = "errorLink", EmitDefaultValue = false)]
        public string ErrorLink { get; set; }

        /// <summary>
        /// A unique identifier for this error. This can be used by Okta Support to help with troubleshooting.
        /// </summary>
        /// <value>A unique identifier for this error. This can be used by Okta Support to help with troubleshooting.</value>
        [DataMember(Name = "errorId", EmitDefaultValue = false)]
        public string ErrorId { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCauses
        /// </summary>
        [DataMember(Name = "errorCauses", EmitDefaultValue = false)]
        public List<ErrorErrorCauses> ErrorCauses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorSummary: ").Append(ErrorSummary).Append("\n");
            sb.Append("  ErrorLink: ").Append(ErrorLink).Append("\n");
            sb.Append("  ErrorId: ").Append(ErrorId).Append("\n");
            sb.Append("  ErrorCauses: ").Append(ErrorCauses).Append("\n");
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
            return this.Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorSummary == input.ErrorSummary ||
                    (this.ErrorSummary != null &&
                    this.ErrorSummary.Equals(input.ErrorSummary))
                ) && 
                (
                    this.ErrorLink == input.ErrorLink ||
                    (this.ErrorLink != null &&
                    this.ErrorLink.Equals(input.ErrorLink))
                ) && 
                (
                    this.ErrorId == input.ErrorId ||
                    (this.ErrorId != null &&
                    this.ErrorId.Equals(input.ErrorId))
                ) && 
                (
                    this.ErrorCauses == input.ErrorCauses ||
                    this.ErrorCauses != null &&
                    input.ErrorCauses != null &&
                    this.ErrorCauses.SequenceEqual(input.ErrorCauses)
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
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.ErrorSummary != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorSummary.GetHashCode();
                }
                if (this.ErrorLink != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorLink.GetHashCode();
                }
                if (this.ErrorId != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorId.GetHashCode();
                }
                if (this.ErrorCauses != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCauses.GetHashCode();
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
