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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// WebAuthnUserFactor
    /// </summary>
    [DataContract(Name = "WebAuthnUserFactor")]
    [JsonConverter(typeof(JsonSubtypes), "FactorType")]
    [JsonSubtypes.KnownSubType(typeof(CallUserFactor), "call")]
    [JsonSubtypes.KnownSubType(typeof(EmailUserFactor), "email")]
    [JsonSubtypes.KnownSubType(typeof(CustomHotpUserFactor), "hotp")]
    [JsonSubtypes.KnownSubType(typeof(PushUserFactor), "push")]
    [JsonSubtypes.KnownSubType(typeof(SecurityQuestionUserFactor), "question")]
    [JsonSubtypes.KnownSubType(typeof(SmsUserFactor), "sms")]
    [JsonSubtypes.KnownSubType(typeof(TokenUserFactor), "token")]
    [JsonSubtypes.KnownSubType(typeof(HardwareUserFactor), "token:hardware")]
    [JsonSubtypes.KnownSubType(typeof(CustomHotpUserFactor), "token:hotp")]
    [JsonSubtypes.KnownSubType(typeof(TotpUserFactor), "token:software:totp")]
    [JsonSubtypes.KnownSubType(typeof(U2fUserFactor), "u2f")]
    [JsonSubtypes.KnownSubType(typeof(WebUserFactor), "web")]
    [JsonSubtypes.KnownSubType(typeof(WebAuthnUserFactor), "webauthn")]
    public partial class WebAuthnUserFactor : UserFactor, IEquatable<WebAuthnUserFactor>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public WebAuthnUserFactorProfile Profile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebAuthnUserFactor {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as WebAuthnUserFactor);
        }

        /// <summary>
        /// Returns true if WebAuthnUserFactor instances are equal
        /// </summary>
        /// <param name="input">Instance of WebAuthnUserFactor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebAuthnUserFactor input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
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
                int hashCode = base.GetHashCode();
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
