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
        public partial class LicenseCeAdminProperties :  IEquatable<LicenseCeAdminProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseCeAdminProperties" /> class.
        /// </summary>
        /// <param name="projectIDs">projectIDs.</param>
        /// <param name="accountIDs">accountIDs.</param>
        /// <param name="comments">comments.</param>
        /// <param name="history">history.</param>
        public LicenseCeAdminProperties(List<string> projectIDs = default(List<string>), List<string> accountIDs = default(List<string>), string comments = default(string), string history = default(string))
        {
            this.ProjectIDs = projectIDs;
            this.AccountIDs = accountIDs;
            this.Comments = comments;
            this.History = history;
        }
        
        /// <summary>
        /// Gets or Sets ProjectIDs
        /// </summary>
        [DataMember(Name="projectIDs", EmitDefaultValue=false)]
        public List<string> ProjectIDs { get; set; }

        /// <summary>
        /// Gets or Sets AccountIDs
        /// </summary>
        [DataMember(Name="accountIDs", EmitDefaultValue=false)]
        public List<string> AccountIDs { get; set; }

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
            sb.Append("class LicenseCeAdminProperties {\n");
            sb.Append("  ProjectIDs: ").Append(ProjectIDs).Append("\n");
            sb.Append("  AccountIDs: ").Append(AccountIDs).Append("\n");
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
            return this.Equals(input as LicenseCeAdminProperties);
        }

        /// <summary>
        /// Returns true if LicenseCeAdminProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of LicenseCeAdminProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseCeAdminProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectIDs == input.ProjectIDs ||
                    this.ProjectIDs != null &&
                    input.ProjectIDs != null &&
                    this.ProjectIDs.SequenceEqual(input.ProjectIDs)
                ) && 
                (
                    this.AccountIDs == input.AccountIDs ||
                    this.AccountIDs != null &&
                    input.AccountIDs != null &&
                    this.AccountIDs.SequenceEqual(input.AccountIDs)
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
                if (this.ProjectIDs != null)
                    hashCode = hashCode * 59 + this.ProjectIDs.GetHashCode();
                if (this.AccountIDs != null)
                    hashCode = hashCode * 59 + this.AccountIDs.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.History != null)
                    hashCode = hashCode * 59 + this.History.GetHashCode();
                return hashCode;
            }
        }
    }
}
