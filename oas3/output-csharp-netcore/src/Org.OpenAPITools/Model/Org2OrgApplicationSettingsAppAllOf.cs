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
    /// Org2OrgApplicationSettingsAppAllOf
    /// </summary>
    [DataContract(Name = "Org2OrgApplicationSettingsApp_allOf")]
    public partial class Org2OrgApplicationSettingsAppAllOf : IEquatable<Org2OrgApplicationSettingsAppAllOf>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets AcsUrl
        /// </summary>
        [DataMember(Name = "acsUrl", EmitDefaultValue = false)]
        public string AcsUrl { get; set; }

        /// <summary>
        /// Gets or Sets AudRestriction
        /// </summary>
        [DataMember(Name = "audRestriction", EmitDefaultValue = false)]
        public string AudRestriction { get; set; }

        /// <summary>
        /// Gets or Sets BaseUrl
        /// </summary>
        [DataMember(Name = "baseUrl", EmitDefaultValue = false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Org2OrgApplicationSettingsAppAllOf {\n");
            sb.Append("  AcsUrl: ").Append(AcsUrl).Append("\n");
            sb.Append("  AudRestriction: ").Append(AudRestriction).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
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
            return this.Equals(input as Org2OrgApplicationSettingsAppAllOf);
        }

        /// <summary>
        /// Returns true if Org2OrgApplicationSettingsAppAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of Org2OrgApplicationSettingsAppAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Org2OrgApplicationSettingsAppAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcsUrl == input.AcsUrl ||
                    (this.AcsUrl != null &&
                    this.AcsUrl.Equals(input.AcsUrl))
                ) && 
                (
                    this.AudRestriction == input.AudRestriction ||
                    (this.AudRestriction != null &&
                    this.AudRestriction.Equals(input.AudRestriction))
                ) && 
                (
                    this.BaseUrl == input.BaseUrl ||
                    (this.BaseUrl != null &&
                    this.BaseUrl.Equals(input.BaseUrl))
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
                if (this.AcsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AcsUrl.GetHashCode();
                }
                if (this.AudRestriction != null)
                {
                    hashCode = (hashCode * 59) + this.AudRestriction.GetHashCode();
                }
                if (this.BaseUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BaseUrl.GetHashCode();
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
