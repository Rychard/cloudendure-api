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
    /// AuditLogEntryParticipatingMachines
    /// </summary>
    [DataContract]
        public partial class AuditLogEntryParticipatingMachines :  IEquatable<AuditLogEntryParticipatingMachines>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEntryParticipatingMachines" /> class.
        /// </summary>
        /// <param name="machineCloudEndureId">machineCloudEndureId.</param>
        /// <param name="machineCloudName">Only present when machine has been given a name in the cloud in which it exists..</param>
        /// <param name="machineCloudId">machineCloudId.</param>
        public AuditLogEntryParticipatingMachines(Guid? machineCloudEndureId = default(Guid?), string machineCloudName = default(string), string machineCloudId = default(string))
        {
            this.MachineCloudEndureId = machineCloudEndureId;
            this.MachineCloudName = machineCloudName;
            this.MachineCloudId = machineCloudId;
        }
        
        /// <summary>
        /// Gets or Sets MachineCloudEndureId
        /// </summary>
        [DataMember(Name="machineCloudEndureId", EmitDefaultValue=false)]
        public Guid? MachineCloudEndureId { get; set; }

        /// <summary>
        /// Only present when machine has been given a name in the cloud in which it exists.
        /// </summary>
        /// <value>Only present when machine has been given a name in the cloud in which it exists.</value>
        [DataMember(Name="machineCloudName", EmitDefaultValue=false)]
        public string MachineCloudName { get; set; }

        /// <summary>
        /// Gets or Sets MachineCloudId
        /// </summary>
        [DataMember(Name="machineCloudId", EmitDefaultValue=false)]
        public string MachineCloudId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditLogEntryParticipatingMachines {\n");
            sb.Append("  MachineCloudEndureId: ").Append(MachineCloudEndureId).Append("\n");
            sb.Append("  MachineCloudName: ").Append(MachineCloudName).Append("\n");
            sb.Append("  MachineCloudId: ").Append(MachineCloudId).Append("\n");
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
            return this.Equals(input as AuditLogEntryParticipatingMachines);
        }

        /// <summary>
        /// Returns true if AuditLogEntryParticipatingMachines instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditLogEntryParticipatingMachines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditLogEntryParticipatingMachines input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MachineCloudEndureId == input.MachineCloudEndureId ||
                    (this.MachineCloudEndureId != null &&
                    this.MachineCloudEndureId.Equals(input.MachineCloudEndureId))
                ) && 
                (
                    this.MachineCloudName == input.MachineCloudName ||
                    (this.MachineCloudName != null &&
                    this.MachineCloudName.Equals(input.MachineCloudName))
                ) && 
                (
                    this.MachineCloudId == input.MachineCloudId ||
                    (this.MachineCloudId != null &&
                    this.MachineCloudId.Equals(input.MachineCloudId))
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
                if (this.MachineCloudEndureId != null)
                    hashCode = hashCode * 59 + this.MachineCloudEndureId.GetHashCode();
                if (this.MachineCloudName != null)
                    hashCode = hashCode * 59 + this.MachineCloudName.GetHashCode();
                if (this.MachineCloudId != null)
                    hashCode = hashCode * 59 + this.MachineCloudId.GetHashCode();
                return hashCode;
            }
        }
    }
}
