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
    /// UsersAndRolesItems
    /// </summary>
    [DataContract]
        public partial class UsersAndRolesItems :  IEquatable<UsersAndRolesItems>
    {
        /// <summary>
        /// Defines Roles
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RolesEnum
        {
            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            [EnumMember(Value = "USER")]
            USER = 1,
            /// <summary>
            /// Enum ACCOUNTADMIN for value: ACCOUNT_ADMIN
            /// </summary>
            [EnumMember(Value = "ACCOUNT_ADMIN")]
            ACCOUNTADMIN = 2,
            /// <summary>
            /// Enum GLOBALREADONLY for value: GLOBAL_READONLY
            /// </summary>
            [EnumMember(Value = "GLOBAL_READONLY")]
            GLOBALREADONLY = 3,
            /// <summary>
            /// Enum MANAGER for value: MANAGER
            /// </summary>
            [EnumMember(Value = "MANAGER")]
            MANAGER = 4        }
        /// <summary>
        /// The list of roles you want to add to the User (when used with the assignRoles API) or the list of roles you want to remove from the User (when used with the revokeRoles API). All Users have the \&quot;User\&quot; role which cannot be removed.  The following cases will be silently ignored: trying to remove the \&quot;User\&quot; role, passing an empty string as a role and using an empty array. 
        /// </summary>
        /// <value>The list of roles you want to add to the User (when used with the assignRoles API) or the list of roles you want to remove from the User (when used with the revokeRoles API). All Users have the \&quot;User\&quot; role which cannot be removed.  The following cases will be silently ignored: trying to remove the \&quot;User\&quot; role, passing an empty string as a role and using an empty array. </value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<RolesEnum> Roles { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersAndRolesItems" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="roles">The list of roles you want to add to the User (when used with the assignRoles API) or the list of roles you want to remove from the User (when used with the revokeRoles API). All Users have the \&quot;User\&quot; role which cannot be removed.  The following cases will be silently ignored: trying to remove the \&quot;User\&quot; role, passing an empty string as a role and using an empty array. .</param>
        public UsersAndRolesItems(string userId = default(string), List<RolesEnum> roles = default(List<RolesEnum>))
        {
            this.UserId = userId;
            this.Roles = roles;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersAndRolesItems {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as UsersAndRolesItems);
        }

        /// <summary>
        /// Returns true if UsersAndRolesItems instances are equal
        /// </summary>
        /// <param name="input">Instance of UsersAndRolesItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersAndRolesItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                return hashCode;
            }
        }
    }
}