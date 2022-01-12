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
    /// Error
    /// </summary>
    [DataContract]
        public partial class Error :  IEquatable<Error>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="errorCode">An Okta code for this type of error.</param>
        /// <param name="errorSummary">A short description of what caused this error. Sometimes this contains dynamically-generated information about your specific error..</param>
        /// <param name="errorLink">An Okta code for this type of error.</param>
        /// <param name="errorId">A unique identifier for this error. This can be used by Okta Support to help with troubleshooting..</param>
        /// <param name="errorCauses">errorCauses.</param>
        public Error(string errorCode = default(string), string errorSummary = default(string), string errorLink = default(string), string errorId = default(string), List<ErrorErrorCauses> errorCauses = default(List<ErrorErrorCauses>))
        {
            this.ErrorCode = errorCode;
            this.ErrorSummary = errorSummary;
            this.ErrorLink = errorLink;
            this.ErrorId = errorId;
            this.ErrorCauses = errorCauses;
        }
        
        /// <summary>
        /// An Okta code for this type of error
        /// </summary>
        /// <value>An Okta code for this type of error</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// A short description of what caused this error. Sometimes this contains dynamically-generated information about your specific error.
        /// </summary>
        /// <value>A short description of what caused this error. Sometimes this contains dynamically-generated information about your specific error.</value>
        [DataMember(Name="errorSummary", EmitDefaultValue=false)]
        public string ErrorSummary { get; set; }

        /// <summary>
        /// An Okta code for this type of error
        /// </summary>
        /// <value>An Okta code for this type of error</value>
        [DataMember(Name="errorLink", EmitDefaultValue=false)]
        public string ErrorLink { get; set; }

        /// <summary>
        /// A unique identifier for this error. This can be used by Okta Support to help with troubleshooting.
        /// </summary>
        /// <value>A unique identifier for this error. This can be used by Okta Support to help with troubleshooting.</value>
        [DataMember(Name="errorId", EmitDefaultValue=false)]
        public string ErrorId { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCauses
        /// </summary>
        [DataMember(Name="errorCauses", EmitDefaultValue=false)]
        public List<ErrorErrorCauses> ErrorCauses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                return false;

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
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorSummary != null)
                    hashCode = hashCode * 59 + this.ErrorSummary.GetHashCode();
                if (this.ErrorLink != null)
                    hashCode = hashCode * 59 + this.ErrorLink.GetHashCode();
                if (this.ErrorId != null)
                    hashCode = hashCode * 59 + this.ErrorId.GetHashCode();
                if (this.ErrorCauses != null)
                    hashCode = hashCode * 59 + this.ErrorCauses.GetHashCode();
                return hashCode;
            }
        }
    }
}
