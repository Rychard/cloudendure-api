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
    /// Body4
    /// </summary>
    [DataContract]
        public partial class Body4 :  IEquatable<Body4>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body4" /> class.
        /// </summary>
        /// <param name="machineIDs">machineIDs.</param>
        /// <param name="destinationProjectId">destinationProjectId.</param>
        public Body4(List<string> machineIDs = default(List<string>), string destinationProjectId = default(string))
        {
            this.MachineIDs = machineIDs;
            this.DestinationProjectId = destinationProjectId;
        }
        
        /// <summary>
        /// Gets or Sets MachineIDs
        /// </summary>
        [DataMember(Name="machineIDs", EmitDefaultValue=false)]
        public List<string> MachineIDs { get; set; }

        /// <summary>
        /// Gets or Sets DestinationProjectId
        /// </summary>
        [DataMember(Name="destinationProjectId", EmitDefaultValue=false)]
        public string DestinationProjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body4 {\n");
            sb.Append("  MachineIDs: ").Append(MachineIDs).Append("\n");
            sb.Append("  DestinationProjectId: ").Append(DestinationProjectId).Append("\n");
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
            return this.Equals(input as Body4);
        }

        /// <summary>
        /// Returns true if Body4 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body4 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MachineIDs == input.MachineIDs ||
                    this.MachineIDs != null &&
                    input.MachineIDs != null &&
                    this.MachineIDs.SequenceEqual(input.MachineIDs)
                ) && 
                (
                    this.DestinationProjectId == input.DestinationProjectId ||
                    (this.DestinationProjectId != null &&
                    this.DestinationProjectId.Equals(input.DestinationProjectId))
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
                if (this.MachineIDs != null)
                    hashCode = hashCode * 59 + this.MachineIDs.GetHashCode();
                if (this.DestinationProjectId != null)
                    hashCode = hashCode * 59 + this.DestinationProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
