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
    /// GCP finance data
    /// </summary>
    [DataContract]
        public partial class GcpMachinesFinanceData :  IEquatable<GcpMachinesFinanceData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcpMachinesFinanceData" /> class.
        /// </summary>
        /// <param name="gcpProjectName">gcpProjectName.</param>
        /// <param name="machineName">machineName.</param>
        /// <param name="numberOfCores">numberOfCores.</param>
        /// <param name="creationTime">creationTime.</param>
        /// <param name="isPreemptible">isPreemptible.</param>
        /// <param name="hasGpu">hasGpu.</param>
        /// <param name="machineId">machineId.</param>
        /// <param name="ceProjectName">ceProjectName.</param>
        public GcpMachinesFinanceData(string gcpProjectName = default(string), string machineName = default(string), int? numberOfCores = default(int?), DateTime? creationTime = default(DateTime?), bool? isPreemptible = default(bool?), bool? hasGpu = default(bool?), string machineId = default(string), string ceProjectName = default(string))
        {
            this.GcpProjectName = gcpProjectName;
            this.MachineName = machineName;
            this.NumberOfCores = numberOfCores;
            this.CreationTime = creationTime;
            this.IsPreemptible = isPreemptible;
            this.HasGpu = hasGpu;
            this.MachineId = machineId;
            this.CeProjectName = ceProjectName;
        }
        
        /// <summary>
        /// Gets or Sets GcpProjectName
        /// </summary>
        [DataMember(Name="gcp_project_name", EmitDefaultValue=false)]
        public string GcpProjectName { get; set; }

        /// <summary>
        /// Gets or Sets MachineName
        /// </summary>
        [DataMember(Name="machine_name", EmitDefaultValue=false)]
        public string MachineName { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfCores
        /// </summary>
        [DataMember(Name="number_of_cores", EmitDefaultValue=false)]
        public int? NumberOfCores { get; set; }

        /// <summary>
        /// Gets or Sets CreationTime
        /// </summary>
        [DataMember(Name="creation_time", EmitDefaultValue=false)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or Sets IsPreemptible
        /// </summary>
        [DataMember(Name="is_preemptible", EmitDefaultValue=false)]
        public bool? IsPreemptible { get; set; }

        /// <summary>
        /// Gets or Sets HasGpu
        /// </summary>
        [DataMember(Name="has_gpu", EmitDefaultValue=false)]
        public bool? HasGpu { get; set; }

        /// <summary>
        /// Gets or Sets MachineId
        /// </summary>
        [DataMember(Name="machine_id", EmitDefaultValue=false)]
        public string MachineId { get; set; }

        /// <summary>
        /// Gets or Sets CeProjectName
        /// </summary>
        [DataMember(Name="ce_project_name", EmitDefaultValue=false)]
        public string CeProjectName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcpMachinesFinanceData {\n");
            sb.Append("  GcpProjectName: ").Append(GcpProjectName).Append("\n");
            sb.Append("  MachineName: ").Append(MachineName).Append("\n");
            sb.Append("  NumberOfCores: ").Append(NumberOfCores).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  IsPreemptible: ").Append(IsPreemptible).Append("\n");
            sb.Append("  HasGpu: ").Append(HasGpu).Append("\n");
            sb.Append("  MachineId: ").Append(MachineId).Append("\n");
            sb.Append("  CeProjectName: ").Append(CeProjectName).Append("\n");
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
            return this.Equals(input as GcpMachinesFinanceData);
        }

        /// <summary>
        /// Returns true if GcpMachinesFinanceData instances are equal
        /// </summary>
        /// <param name="input">Instance of GcpMachinesFinanceData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcpMachinesFinanceData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GcpProjectName == input.GcpProjectName ||
                    (this.GcpProjectName != null &&
                    this.GcpProjectName.Equals(input.GcpProjectName))
                ) && 
                (
                    this.MachineName == input.MachineName ||
                    (this.MachineName != null &&
                    this.MachineName.Equals(input.MachineName))
                ) && 
                (
                    this.NumberOfCores == input.NumberOfCores ||
                    (this.NumberOfCores != null &&
                    this.NumberOfCores.Equals(input.NumberOfCores))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.IsPreemptible == input.IsPreemptible ||
                    (this.IsPreemptible != null &&
                    this.IsPreemptible.Equals(input.IsPreemptible))
                ) && 
                (
                    this.HasGpu == input.HasGpu ||
                    (this.HasGpu != null &&
                    this.HasGpu.Equals(input.HasGpu))
                ) && 
                (
                    this.MachineId == input.MachineId ||
                    (this.MachineId != null &&
                    this.MachineId.Equals(input.MachineId))
                ) && 
                (
                    this.CeProjectName == input.CeProjectName ||
                    (this.CeProjectName != null &&
                    this.CeProjectName.Equals(input.CeProjectName))
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
                if (this.GcpProjectName != null)
                    hashCode = hashCode * 59 + this.GcpProjectName.GetHashCode();
                if (this.MachineName != null)
                    hashCode = hashCode * 59 + this.MachineName.GetHashCode();
                if (this.NumberOfCores != null)
                    hashCode = hashCode * 59 + this.NumberOfCores.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.IsPreemptible != null)
                    hashCode = hashCode * 59 + this.IsPreemptible.GetHashCode();
                if (this.HasGpu != null)
                    hashCode = hashCode * 59 + this.HasGpu.GetHashCode();
                if (this.MachineId != null)
                    hashCode = hashCode * 59 + this.MachineId.GetHashCode();
                if (this.CeProjectName != null)
                    hashCode = hashCode * 59 + this.CeProjectName.GetHashCode();
                return hashCode;
            }
        }
    }
}
