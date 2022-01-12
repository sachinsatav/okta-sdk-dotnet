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
    /// OpenIdConnectApplicationSettingsRefreshToken
    /// </summary>
    [DataContract]
        public partial class OpenIdConnectApplicationSettingsRefreshToken :  IEquatable<OpenIdConnectApplicationSettingsRefreshToken>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenIdConnectApplicationSettingsRefreshToken" /> class.
        /// </summary>
        /// <param name="leeway">leeway.</param>
        /// <param name="rotationType">rotationType.</param>
        public OpenIdConnectApplicationSettingsRefreshToken(int? leeway = default(int?), OpenIdConnectRefreshTokenRotationType rotationType = default(OpenIdConnectRefreshTokenRotationType))
        {
            this.Leeway = leeway;
            this.RotationType = rotationType;
        }
        
        /// <summary>
        /// Gets or Sets Leeway
        /// </summary>
        [DataMember(Name="leeway", EmitDefaultValue=false)]
        public int? Leeway { get; set; }

        /// <summary>
        /// Gets or Sets RotationType
        /// </summary>
        [DataMember(Name="rotation_type", EmitDefaultValue=false)]
        public OpenIdConnectRefreshTokenRotationType RotationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenIdConnectApplicationSettingsRefreshToken {\n");
            sb.Append("  Leeway: ").Append(Leeway).Append("\n");
            sb.Append("  RotationType: ").Append(RotationType).Append("\n");
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
            return this.Equals(input as OpenIdConnectApplicationSettingsRefreshToken);
        }

        /// <summary>
        /// Returns true if OpenIdConnectApplicationSettingsRefreshToken instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenIdConnectApplicationSettingsRefreshToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenIdConnectApplicationSettingsRefreshToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Leeway == input.Leeway ||
                    (this.Leeway != null &&
                    this.Leeway.Equals(input.Leeway))
                ) && 
                (
                    this.RotationType == input.RotationType ||
                    (this.RotationType != null &&
                    this.RotationType.Equals(input.RotationType))
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
                if (this.Leeway != null)
                    hashCode = hashCode * 59 + this.Leeway.GetHashCode();
                if (this.RotationType != null)
                    hashCode = hashCode * 59 + this.RotationType.GetHashCode();
                return hashCode;
            }
        }
    }
}
