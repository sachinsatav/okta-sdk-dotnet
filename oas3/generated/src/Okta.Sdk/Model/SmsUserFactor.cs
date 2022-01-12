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
    /// SmsUserFactor
    /// </summary>
    [DataContract]
        public partial class SmsUserFactor :  IEquatable<SmsUserFactor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsUserFactor" /> class.
        /// </summary>
        /// <param name="profile">profile.</param>
        public SmsUserFactor(SmsUserFactorProfile profile = default(SmsUserFactorProfile))
        {
            this.Profile = profile;
        }
        
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public SmsUserFactorProfile Profile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsUserFactor {\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
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
            return this.Equals(input as SmsUserFactor);
        }

        /// <summary>
        /// Returns true if SmsUserFactor instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsUserFactor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsUserFactor input)
        {
            if (input == null)
                return false;

            return 
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
                int hashCode = 41;
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                return hashCode;
            }
        }
    }
}
