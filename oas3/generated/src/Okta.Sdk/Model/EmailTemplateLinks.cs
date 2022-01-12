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
    /// EmailTemplateLinks
    /// </summary>
    [DataContract]
        public partial class EmailTemplateLinks :  IEquatable<EmailTemplateLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplateLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="customizations">customizations.</param>
        /// <param name="defaultContent">defaultContent.</param>
        /// <param name="test">test.</param>
        public EmailTemplateLinks(HrefObject self = default(HrefObject), HrefObject customizations = default(HrefObject), HrefObject defaultContent = default(HrefObject), HrefObject test = default(HrefObject))
        {
            this.Self = self;
            this.Customizations = customizations;
            this.DefaultContent = defaultContent;
            this.Test = test;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public HrefObject Self { get; set; }

        /// <summary>
        /// Gets or Sets Customizations
        /// </summary>
        [DataMember(Name="customizations", EmitDefaultValue=false)]
        public HrefObject Customizations { get; set; }

        /// <summary>
        /// Gets or Sets DefaultContent
        /// </summary>
        [DataMember(Name="defaultContent", EmitDefaultValue=false)]
        public HrefObject DefaultContent { get; set; }

        /// <summary>
        /// Gets or Sets Test
        /// </summary>
        [DataMember(Name="test", EmitDefaultValue=false)]
        public HrefObject Test { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailTemplateLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Customizations: ").Append(Customizations).Append("\n");
            sb.Append("  DefaultContent: ").Append(DefaultContent).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
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
            return this.Equals(input as EmailTemplateLinks);
        }

        /// <summary>
        /// Returns true if EmailTemplateLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailTemplateLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailTemplateLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Customizations == input.Customizations ||
                    (this.Customizations != null &&
                    this.Customizations.Equals(input.Customizations))
                ) && 
                (
                    this.DefaultContent == input.DefaultContent ||
                    (this.DefaultContent != null &&
                    this.DefaultContent.Equals(input.DefaultContent))
                ) && 
                (
                    this.Test == input.Test ||
                    (this.Test != null &&
                    this.Test.Equals(input.Test))
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
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Customizations != null)
                    hashCode = hashCode * 59 + this.Customizations.GetHashCode();
                if (this.DefaultContent != null)
                    hashCode = hashCode * 59 + this.DefaultContent.GetHashCode();
                if (this.Test != null)
                    hashCode = hashCode * 59 + this.Test.GetHashCode();
                return hashCode;
            }
        }
    }
}
