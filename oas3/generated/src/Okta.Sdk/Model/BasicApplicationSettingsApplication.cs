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
    /// BasicApplicationSettingsApplication
    /// </summary>
    [DataContract]
        public partial class BasicApplicationSettingsApplication :  IEquatable<BasicApplicationSettingsApplication>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicApplicationSettingsApplication" /> class.
        /// </summary>
        /// <param name="authURL">authURL.</param>
        /// <param name="url">url.</param>
        public BasicApplicationSettingsApplication(string authURL = default(string), string url = default(string))
        {
            this.AuthURL = authURL;
            this.Url = url;
        }
        
        /// <summary>
        /// Gets or Sets AuthURL
        /// </summary>
        [DataMember(Name="authURL", EmitDefaultValue=false)]
        public string AuthURL { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicApplicationSettingsApplication {\n");
            sb.Append("  AuthURL: ").Append(AuthURL).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as BasicApplicationSettingsApplication);
        }

        /// <summary>
        /// Returns true if BasicApplicationSettingsApplication instances are equal
        /// </summary>
        /// <param name="input">Instance of BasicApplicationSettingsApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasicApplicationSettingsApplication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthURL == input.AuthURL ||
                    (this.AuthURL != null &&
                    this.AuthURL.Equals(input.AuthURL))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.AuthURL != null)
                    hashCode = hashCode * 59 + this.AuthURL.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }
}
