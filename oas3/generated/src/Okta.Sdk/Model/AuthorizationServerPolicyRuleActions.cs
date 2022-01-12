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
    /// AuthorizationServerPolicyRuleActions
    /// </summary>
    [DataContract]
        public partial class AuthorizationServerPolicyRuleActions :  IEquatable<AuthorizationServerPolicyRuleActions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationServerPolicyRuleActions" /> class.
        /// </summary>
        /// <param name="token">token.</param>
        public AuthorizationServerPolicyRuleActions(TokenAuthorizationServerPolicyRuleAction token = default(TokenAuthorizationServerPolicyRuleAction))
        {
            this.Token = token;
        }
        
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public TokenAuthorizationServerPolicyRuleAction Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizationServerPolicyRuleActions {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as AuthorizationServerPolicyRuleActions);
        }

        /// <summary>
        /// Returns true if AuthorizationServerPolicyRuleActions instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizationServerPolicyRuleActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizationServerPolicyRuleActions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }
    }
}
