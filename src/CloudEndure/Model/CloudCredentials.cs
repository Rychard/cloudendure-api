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
    /// An object identifying the credentials used by CloudEndure to act on behalf of the user in a specific cloud.
    /// </summary>
    [DataContract]
        public partial class CloudCredentials :  IEquatable<CloudCredentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudCredentials" /> class.
        /// </summary>
        /// <param name="publicKey">The public part of the Cloud credentials. For AWS - access key ID; for GCP - user email; for Azure - SHA1 digestion of the certificate file. .</param>
        /// <param name="name">An optional (can be empty), user provided, descriptive name..</param>
        public CloudCredentials(string publicKey = default(string), string name = default(string))
        {
            this.PublicKey = publicKey;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The public part of the Cloud credentials. For AWS - access key ID; for GCP - user email; for Azure - SHA1 digestion of the certificate file. 
        /// </summary>
        /// <value>The public part of the Cloud credentials. For AWS - access key ID; for GCP - user email; for Azure - SHA1 digestion of the certificate file. </value>
        [DataMember(Name="publicKey", EmitDefaultValue=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// An ID provided by the cloud for the user account.
        /// </summary>
        /// <value>An ID provided by the cloud for the user account.</value>
        [DataMember(Name="accountIdentifier", EmitDefaultValue=false)]
        public string AccountIdentifier { get; private set; }

        /// <summary>
        /// Gets or Sets Cloud
        /// </summary>
        [DataMember(Name="cloud", EmitDefaultValue=false)]
        public string Cloud { get; private set; }

        /// <summary>
        /// An optional (can be empty), user provided, descriptive name.
        /// </summary>
        /// <value>An optional (can be empty), user provided, descriptive name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudCredentials {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  AccountIdentifier: ").Append(AccountIdentifier).Append("\n");
            sb.Append("  Cloud: ").Append(Cloud).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as CloudCredentials);
        }

        /// <summary>
        /// Returns true if CloudCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && 
                (
                    this.AccountIdentifier == input.AccountIdentifier ||
                    (this.AccountIdentifier != null &&
                    this.AccountIdentifier.Equals(input.AccountIdentifier))
                ) && 
                (
                    this.Cloud == input.Cloud ||
                    (this.Cloud != null &&
                    this.Cloud.Equals(input.Cloud))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.AccountIdentifier != null)
                    hashCode = hashCode * 59 + this.AccountIdentifier.GetHashCode();
                if (this.Cloud != null)
                    hashCode = hashCode * 59 + this.Cloud.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
