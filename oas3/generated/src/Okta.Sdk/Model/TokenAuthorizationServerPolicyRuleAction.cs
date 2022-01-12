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
    /// TokenAuthorizationServerPolicyRuleAction
    /// </summary>
    [DataContract]
        public partial class TokenAuthorizationServerPolicyRuleAction :  IEquatable<TokenAuthorizationServerPolicyRuleAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenAuthorizationServerPolicyRuleAction" /> class.
        /// </summary>
        /// <param name="accessTokenLifetimeMinutes">accessTokenLifetimeMinutes.</param>
        /// <param name="refreshTokenLifetimeMinutes">refreshTokenLifetimeMinutes.</param>
        /// <param name="refreshTokenWindowMinutes">refreshTokenWindowMinutes.</param>
        /// <param name="inlineHook">inlineHook.</param>
        public TokenAuthorizationServerPolicyRuleAction(int? accessTokenLifetimeMinutes = default(int?), int? refreshTokenLifetimeMinutes = default(int?), int? refreshTokenWindowMinutes = default(int?), TokenAuthorizationServerPolicyRuleActionInlineHook inlineHook = default(TokenAuthorizationServerPolicyRuleActionInlineHook))
        {
            this.AccessTokenLifetimeMinutes = accessTokenLifetimeMinutes;
            this.RefreshTokenLifetimeMinutes = refreshTokenLifetimeMinutes;
            this.RefreshTokenWindowMinutes = refreshTokenWindowMinutes;
            this.InlineHook = inlineHook;
        }
        
        /// <summary>
        /// Gets or Sets AccessTokenLifetimeMinutes
        /// </summary>
        [DataMember(Name="accessTokenLifetimeMinutes", EmitDefaultValue=false)]
        public int? AccessTokenLifetimeMinutes { get; set; }

        /// <summary>
        /// Gets or Sets RefreshTokenLifetimeMinutes
        /// </summary>
        [DataMember(Name="refreshTokenLifetimeMinutes", EmitDefaultValue=false)]
        public int? RefreshTokenLifetimeMinutes { get; set; }

        /// <summary>
        /// Gets or Sets RefreshTokenWindowMinutes
        /// </summary>
        [DataMember(Name="refreshTokenWindowMinutes", EmitDefaultValue=false)]
        public int? RefreshTokenWindowMinutes { get; set; }

        /// <summary>
        /// Gets or Sets InlineHook
        /// </summary>
        [DataMember(Name="inlineHook", EmitDefaultValue=false)]
        public TokenAuthorizationServerPolicyRuleActionInlineHook InlineHook { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenAuthorizationServerPolicyRuleAction {\n");
            sb.Append("  AccessTokenLifetimeMinutes: ").Append(AccessTokenLifetimeMinutes).Append("\n");
            sb.Append("  RefreshTokenLifetimeMinutes: ").Append(RefreshTokenLifetimeMinutes).Append("\n");
            sb.Append("  RefreshTokenWindowMinutes: ").Append(RefreshTokenWindowMinutes).Append("\n");
            sb.Append("  InlineHook: ").Append(InlineHook).Append("\n");
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
            return this.Equals(input as TokenAuthorizationServerPolicyRuleAction);
        }

        /// <summary>
        /// Returns true if TokenAuthorizationServerPolicyRuleAction instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenAuthorizationServerPolicyRuleAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenAuthorizationServerPolicyRuleAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessTokenLifetimeMinutes == input.AccessTokenLifetimeMinutes ||
                    (this.AccessTokenLifetimeMinutes != null &&
                    this.AccessTokenLifetimeMinutes.Equals(input.AccessTokenLifetimeMinutes))
                ) && 
                (
                    this.RefreshTokenLifetimeMinutes == input.RefreshTokenLifetimeMinutes ||
                    (this.RefreshTokenLifetimeMinutes != null &&
                    this.RefreshTokenLifetimeMinutes.Equals(input.RefreshTokenLifetimeMinutes))
                ) && 
                (
                    this.RefreshTokenWindowMinutes == input.RefreshTokenWindowMinutes ||
                    (this.RefreshTokenWindowMinutes != null &&
                    this.RefreshTokenWindowMinutes.Equals(input.RefreshTokenWindowMinutes))
                ) && 
                (
                    this.InlineHook == input.InlineHook ||
                    (this.InlineHook != null &&
                    this.InlineHook.Equals(input.InlineHook))
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
                if (this.AccessTokenLifetimeMinutes != null)
                    hashCode = hashCode * 59 + this.AccessTokenLifetimeMinutes.GetHashCode();
                if (this.RefreshTokenLifetimeMinutes != null)
                    hashCode = hashCode * 59 + this.RefreshTokenLifetimeMinutes.GetHashCode();
                if (this.RefreshTokenWindowMinutes != null)
                    hashCode = hashCode * 59 + this.RefreshTokenWindowMinutes.GetHashCode();
                if (this.InlineHook != null)
                    hashCode = hashCode * 59 + this.InlineHook.GetHashCode();
                return hashCode;
            }
        }
    }
}
