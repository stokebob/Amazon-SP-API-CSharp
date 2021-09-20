/* 
 * Selling Partner API for Authorization
 *
 * The Selling Partner API for Authorization helps developers manage authorizations and check the specific permissions associated with a given authorization.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Authorization
{
    /// <summary>
    /// A Login with Amazon (LWA) authorization code.
    /// </summary>
    [DataContract]
    public partial class AuthorizationCode : IEquatable<AuthorizationCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationCode" /> class.
        /// </summary>
        /// <param name="_AuthorizationCode">A Login with Amazon (LWA) authorization code that can be exchanged for a refresh token and access token that authorize you to make calls to a Selling Partner API..</param>
        public AuthorizationCode(string _AuthorizationCode = default(string))
        {
            this._AuthorizationCode = _AuthorizationCode;
        }

        /// <summary>
        /// A Login with Amazon (LWA) authorization code that can be exchanged for a refresh token and access token that authorize you to make calls to a Selling Partner API.
        /// </summary>
        /// <value>A Login with Amazon (LWA) authorization code that can be exchanged for a refresh token and access token that authorize you to make calls to a Selling Partner API.</value>
        [DataMember(Name = "authorizationCode", EmitDefaultValue = false)]
        public string _AuthorizationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizationCode {\n");
            sb.Append("  _AuthorizationCode: ").Append(_AuthorizationCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as AuthorizationCode);
        }

        /// <summary>
        /// Returns true if AuthorizationCode instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizationCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizationCode input)
        {
            if (input == null)
                return false;

            return
                (
                    this._AuthorizationCode == input._AuthorizationCode ||
                    (this._AuthorizationCode != null &&
                    this._AuthorizationCode.Equals(input._AuthorizationCode))
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
                if (this._AuthorizationCode != null)
                    hashCode = hashCode * 59 + this._AuthorizationCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}