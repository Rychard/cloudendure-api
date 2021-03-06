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
    /// For internal use.
    /// </summary>
    [DataContract]
        public partial class AccountCeAdminProperties :  IEquatable<AccountCeAdminProperties>
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,
            /// <summary>
            /// Enum NOTACTIVE for value: NOT_ACTIVE
            /// </summary>
            [EnumMember(Value = "NOT_ACTIVE")]
            NOTACTIVE = 2,
            /// <summary>
            /// Enum UPGRADING for value: UPGRADING
            /// </summary>
            [EnumMember(Value = "UPGRADING")]
            UPGRADING = 3        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCeAdminProperties" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="version">version.</param>
        /// <param name="accountOwnerUsername">accountOwnerUsername.</param>
        /// <param name="apisPerMinute">apisPerMinute.</param>
        /// <param name="comments">comments.</param>
        /// <param name="history">history.</param>
        public AccountCeAdminProperties(StateEnum? state = default(StateEnum?), string version = default(string), string accountOwnerUsername = default(string), int? apisPerMinute = default(int?), string comments = default(string), string history = default(string))
        {
            this.State = state;
            this.Version = version;
            this.AccountOwnerUsername = accountOwnerUsername;
            this.ApisPerMinute = apisPerMinute;
            this.Comments = comments;
            this.History = history;
        }
        

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets AccountOwnerUsername
        /// </summary>
        [DataMember(Name="accountOwnerUsername", EmitDefaultValue=false)]
        public string AccountOwnerUsername { get; set; }

        /// <summary>
        /// Gets or Sets ApisPerMinute
        /// </summary>
        [DataMember(Name="apisPerMinute", EmitDefaultValue=false)]
        public int? ApisPerMinute { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets History
        /// </summary>
        [DataMember(Name="history", EmitDefaultValue=false)]
        public string History { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountCeAdminProperties {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  AccountOwnerUsername: ").Append(AccountOwnerUsername).Append("\n");
            sb.Append("  ApisPerMinute: ").Append(ApisPerMinute).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
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
            return this.Equals(input as AccountCeAdminProperties);
        }

        /// <summary>
        /// Returns true if AccountCeAdminProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountCeAdminProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCeAdminProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.AccountOwnerUsername == input.AccountOwnerUsername ||
                    (this.AccountOwnerUsername != null &&
                    this.AccountOwnerUsername.Equals(input.AccountOwnerUsername))
                ) && 
                (
                    this.ApisPerMinute == input.ApisPerMinute ||
                    (this.ApisPerMinute != null &&
                    this.ApisPerMinute.Equals(input.ApisPerMinute))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.History == input.History ||
                    (this.History != null &&
                    this.History.Equals(input.History))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.AccountOwnerUsername != null)
                    hashCode = hashCode * 59 + this.AccountOwnerUsername.GetHashCode();
                if (this.ApisPerMinute != null)
                    hashCode = hashCode * 59 + this.ApisPerMinute.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.History != null)
                    hashCode = hashCode * 59 + this.History.GetHashCode();
                return hashCode;
            }
        }
    }
}
