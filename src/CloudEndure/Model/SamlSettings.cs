/* 
 * CloudEndure API documentation
 *
 * © 2019 CloudEndure All rights reserved  # General Request authentication in CloudEndure's API is done using session cookies. A session cookie is returned upon successful execution of the \"login\" method. This value must then be provided within the request headers of all subsequent API requests.  ## Errors Some errors are not specifically written in every method since they may always return. Those are: 1) 401 (Unauthorized) - for unauthenticated requests. 2) 405 (Method Not Allowed) - for using a method that is not supported (POST instead of GET). 3) 403 (Forbidden) - request is authenticated, but the user is not allowed to access. 4) 422 (Unprocessable Entity) - for invalid input.  ## Formats All strings with date-time format are according to RFC3339.  All strings with \"duration\" format are according to ISO8601. For example, a full day duration can be specified with \"PNNNND\". 
 *
 * OpenAPI spec version: 5
 * 
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
using SwaggerDateConverter = CloudEndure.Client.SwaggerDateConverter;

namespace CloudEndure.Model
{
    /// <summary>
    /// SamlSettings
    /// </summary>
    [DataContract]
        public partial class SamlSettings :  IEquatable<SamlSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SamlSettings" /> class.
        /// </summary>
        /// <param name="identityProviderCertificate">identityProviderCertificate.</param>
        /// <param name="identityProviderUrl">identityProviderUrl.</param>
        /// <param name="identityProviderID">identityProviderID.</param>
        public SamlSettings(string identityProviderCertificate = default(string), string identityProviderUrl = default(string), string identityProviderID = default(string))
        {
            this.IdentityProviderCertificate = identityProviderCertificate;
            this.IdentityProviderUrl = identityProviderUrl;
            this.IdentityProviderID = identityProviderID;
        }
        
        /// <summary>
        /// Gets or Sets IdentityProviderCertificate
        /// </summary>
        [DataMember(Name="identityProviderCertificate", EmitDefaultValue=false)]
        public string IdentityProviderCertificate { get; set; }

        /// <summary>
        /// Gets or Sets IdentityProviderUrl
        /// </summary>
        [DataMember(Name="identityProviderUrl", EmitDefaultValue=false)]
        public string IdentityProviderUrl { get; set; }

        /// <summary>
        /// Gets or Sets IdentityProviderID
        /// </summary>
        [DataMember(Name="identityProviderID", EmitDefaultValue=false)]
        public string IdentityProviderID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SamlSettings {\n");
            sb.Append("  IdentityProviderCertificate: ").Append(IdentityProviderCertificate).Append("\n");
            sb.Append("  IdentityProviderUrl: ").Append(IdentityProviderUrl).Append("\n");
            sb.Append("  IdentityProviderID: ").Append(IdentityProviderID).Append("\n");
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
            return this.Equals(input as SamlSettings);
        }

        /// <summary>
        /// Returns true if SamlSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of SamlSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SamlSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentityProviderCertificate == input.IdentityProviderCertificate ||
                    (this.IdentityProviderCertificate != null &&
                    this.IdentityProviderCertificate.Equals(input.IdentityProviderCertificate))
                ) && 
                (
                    this.IdentityProviderUrl == input.IdentityProviderUrl ||
                    (this.IdentityProviderUrl != null &&
                    this.IdentityProviderUrl.Equals(input.IdentityProviderUrl))
                ) && 
                (
                    this.IdentityProviderID == input.IdentityProviderID ||
                    (this.IdentityProviderID != null &&
                    this.IdentityProviderID.Equals(input.IdentityProviderID))
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
                if (this.IdentityProviderCertificate != null)
                    hashCode = hashCode * 59 + this.IdentityProviderCertificate.GetHashCode();
                if (this.IdentityProviderUrl != null)
                    hashCode = hashCode * 59 + this.IdentityProviderUrl.GetHashCode();
                if (this.IdentityProviderID != null)
                    hashCode = hashCode * 59 + this.IdentityProviderID.GetHashCode();
                return hashCode;
            }
        }
    }
}
