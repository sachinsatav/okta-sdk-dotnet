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
    /// OpenIdConnectApplication
    /// </summary>
    [DataContract]
        public partial class OpenIdConnectApplication :  IEquatable<OpenIdConnectApplication>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenIdConnectApplication" /> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="name">name (default to &quot;oidc_client&quot;).</param>
        /// <param name="settings">settings.</param>
        public OpenIdConnectApplication(OAuthApplicationCredentials credentials = default(OAuthApplicationCredentials), string name = "oidc_client", OpenIdConnectApplicationSettings settings = default(OpenIdConnectApplicationSettings))
        {
            this.Credentials = credentials;
            // use default value if no "name" provided
            if (name == null)
            {
                this.Name = "oidc_client";
            }
            else
            {
                this.Name = name;
            }
            this.Settings = settings;
        }
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public OAuthApplicationCredentials Credentials { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public OpenIdConnectApplicationSettings Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenIdConnectApplication {\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as OpenIdConnectApplication);
        }

        /// <summary>
        /// Returns true if OpenIdConnectApplication instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenIdConnectApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenIdConnectApplication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                return hashCode;
            }
        }
    }
}
