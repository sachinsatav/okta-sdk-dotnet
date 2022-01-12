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
    /// BasicApplicationSettings
    /// </summary>
    [DataContract]
        public partial class BasicApplicationSettings :  IEquatable<BasicApplicationSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicApplicationSettings" /> class.
        /// </summary>
        /// <param name="app">app.</param>
        public BasicApplicationSettings(BasicApplicationSettingsApplication app = default(BasicApplicationSettingsApplication))
        {
            this.App = app;
        }
        
        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name="app", EmitDefaultValue=false)]
        public BasicApplicationSettingsApplication App { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicApplicationSettings {\n");
            sb.Append("  App: ").Append(App).Append("\n");
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
            return this.Equals(input as BasicApplicationSettings);
        }

        /// <summary>
        /// Returns true if BasicApplicationSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of BasicApplicationSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasicApplicationSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
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
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
                return hashCode;
            }
        }
    }
}
