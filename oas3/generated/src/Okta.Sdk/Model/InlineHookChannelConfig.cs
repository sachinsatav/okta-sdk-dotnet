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
    /// InlineHookChannelConfig
    /// </summary>
    [DataContract]
        public partial class InlineHookChannelConfig :  IEquatable<InlineHookChannelConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineHookChannelConfig" /> class.
        /// </summary>
        /// <param name="authScheme">authScheme.</param>
        /// <param name="headers">headers.</param>
        /// <param name="uri">uri.</param>
        /// <param name="method">method.</param>
        public InlineHookChannelConfig(InlineHookChannelConfigAuthScheme authScheme = default(InlineHookChannelConfigAuthScheme), List<InlineHookChannelConfigHeaders> headers = default(List<InlineHookChannelConfigHeaders>), string uri = default(string), string method = default(string))
        {
            this.AuthScheme = authScheme;
            this.Headers = headers;
            this.Uri = uri;
            this.Method = method;
        }
        
        /// <summary>
        /// Gets or Sets AuthScheme
        /// </summary>
        [DataMember(Name="authScheme", EmitDefaultValue=false)]
        public InlineHookChannelConfigAuthScheme AuthScheme { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public List<InlineHookChannelConfigHeaders> Headers { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineHookChannelConfig {\n");
            sb.Append("  AuthScheme: ").Append(AuthScheme).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(input as InlineHookChannelConfig);
        }

        /// <summary>
        /// Returns true if InlineHookChannelConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineHookChannelConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineHookChannelConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthScheme == input.AuthScheme ||
                    (this.AuthScheme != null &&
                    this.AuthScheme.Equals(input.AuthScheme))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
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
                if (this.AuthScheme != null)
                    hashCode = hashCode * 59 + this.AuthScheme.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                return hashCode;
            }
        }
    }
}
