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
    /// ProtocolEndpoints
    /// </summary>
    [DataContract(Name = "ProtocolEndpoints")]
    public partial class ProtocolEndpoints : IEquatable<ProtocolEndpoints>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets Acs
        /// </summary>
        [DataMember(Name = "acs", EmitDefaultValue = false)]
        public ProtocolEndpoint Acs { get; set; }

        /// <summary>
        /// Gets or Sets Authorization
        /// </summary>
        [DataMember(Name = "authorization", EmitDefaultValue = false)]
        public ProtocolEndpoint Authorization { get; set; }

        /// <summary>
        /// Gets or Sets Jwks
        /// </summary>
        [DataMember(Name = "jwks", EmitDefaultValue = false)]
        public ProtocolEndpoint Jwks { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public ProtocolEndpoint Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Slo
        /// </summary>
        [DataMember(Name = "slo", EmitDefaultValue = false)]
        public ProtocolEndpoint Slo { get; set; }

        /// <summary>
        /// Gets or Sets Sso
        /// </summary>
        [DataMember(Name = "sso", EmitDefaultValue = false)]
        public ProtocolEndpoint Sso { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public ProtocolEndpoint Token { get; set; }

        /// <summary>
        /// Gets or Sets UserInfo
        /// </summary>
        [DataMember(Name = "userInfo", EmitDefaultValue = false)]
        public ProtocolEndpoint UserInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProtocolEndpoints {\n");
            sb.Append("  Acs: ").Append(Acs).Append("\n");
            sb.Append("  Authorization: ").Append(Authorization).Append("\n");
            sb.Append("  Jwks: ").Append(Jwks).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Slo: ").Append(Slo).Append("\n");
            sb.Append("  Sso: ").Append(Sso).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UserInfo: ").Append(UserInfo).Append("\n");
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
            return this.Equals(input as ProtocolEndpoints);
        }

        /// <summary>
        /// Returns true if ProtocolEndpoints instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtocolEndpoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtocolEndpoints input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Acs == input.Acs ||
                    (this.Acs != null &&
                    this.Acs.Equals(input.Acs))
                ) && 
                (
                    this.Authorization == input.Authorization ||
                    (this.Authorization != null &&
                    this.Authorization.Equals(input.Authorization))
                ) && 
                (
                    this.Jwks == input.Jwks ||
                    (this.Jwks != null &&
                    this.Jwks.Equals(input.Jwks))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Slo == input.Slo ||
                    (this.Slo != null &&
                    this.Slo.Equals(input.Slo))
                ) && 
                (
                    this.Sso == input.Sso ||
                    (this.Sso != null &&
                    this.Sso.Equals(input.Sso))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.UserInfo == input.UserInfo ||
                    (this.UserInfo != null &&
                    this.UserInfo.Equals(input.UserInfo))
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
                if (this.Acs != null)
                {
                    hashCode = (hashCode * 59) + this.Acs.GetHashCode();
                }
                if (this.Authorization != null)
                {
                    hashCode = (hashCode * 59) + this.Authorization.GetHashCode();
                }
                if (this.Jwks != null)
                {
                    hashCode = (hashCode * 59) + this.Jwks.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.Slo != null)
                {
                    hashCode = (hashCode * 59) + this.Slo.GetHashCode();
                }
                if (this.Sso != null)
                {
                    hashCode = (hashCode * 59) + this.Sso.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.UserInfo != null)
                {
                    hashCode = (hashCode * 59) + this.UserInfo.GetHashCode();
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
