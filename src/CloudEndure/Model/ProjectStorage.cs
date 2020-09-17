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
    /// total storage used by a project
    /// </summary>
    [DataContract]
        public partial class ProjectStorage :  IEquatable<ProjectStorage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStorage" /> class.
        /// </summary>
        /// <param name="projectId">projectId.</param>
        /// <param name="pointsInTimeTotalBytes">pointsInTimeTotalBytes.</param>
        /// <param name="runningMachinesTotalBytes">runningMachinesTotalBytes.</param>
        /// <param name="workingStorage">workingStorage.</param>
        /// <param name="calculationDateTime">calculationDateTime.</param>
        public ProjectStorage(string projectId = default(string), long? pointsInTimeTotalBytes = default(long?), long? runningMachinesTotalBytes = default(long?), ProjectStorageWorkingStorage workingStorage = default(ProjectStorageWorkingStorage), DateTime? calculationDateTime = default(DateTime?))
        {
            this.ProjectId = projectId;
            this.PointsInTimeTotalBytes = pointsInTimeTotalBytes;
            this.RunningMachinesTotalBytes = runningMachinesTotalBytes;
            this.WorkingStorage = workingStorage;
            this.CalculationDateTime = calculationDateTime;
        }
        
        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="projectId", EmitDefaultValue=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets PointsInTimeTotalBytes
        /// </summary>
        [DataMember(Name="pointsInTimeTotalBytes", EmitDefaultValue=false)]
        public long? PointsInTimeTotalBytes { get; set; }

        /// <summary>
        /// Gets or Sets RunningMachinesTotalBytes
        /// </summary>
        [DataMember(Name="runningMachinesTotalBytes", EmitDefaultValue=false)]
        public long? RunningMachinesTotalBytes { get; set; }

        /// <summary>
        /// Gets or Sets WorkingStorage
        /// </summary>
        [DataMember(Name="workingStorage", EmitDefaultValue=false)]
        public ProjectStorageWorkingStorage WorkingStorage { get; set; }

        /// <summary>
        /// Gets or Sets CalculationDateTime
        /// </summary>
        [DataMember(Name="calculationDateTime", EmitDefaultValue=false)]
        public DateTime? CalculationDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectStorage {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  PointsInTimeTotalBytes: ").Append(PointsInTimeTotalBytes).Append("\n");
            sb.Append("  RunningMachinesTotalBytes: ").Append(RunningMachinesTotalBytes).Append("\n");
            sb.Append("  WorkingStorage: ").Append(WorkingStorage).Append("\n");
            sb.Append("  CalculationDateTime: ").Append(CalculationDateTime).Append("\n");
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
            return this.Equals(input as ProjectStorage);
        }

        /// <summary>
        /// Returns true if ProjectStorage instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectStorage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectStorage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.PointsInTimeTotalBytes == input.PointsInTimeTotalBytes ||
                    (this.PointsInTimeTotalBytes != null &&
                    this.PointsInTimeTotalBytes.Equals(input.PointsInTimeTotalBytes))
                ) && 
                (
                    this.RunningMachinesTotalBytes == input.RunningMachinesTotalBytes ||
                    (this.RunningMachinesTotalBytes != null &&
                    this.RunningMachinesTotalBytes.Equals(input.RunningMachinesTotalBytes))
                ) && 
                (
                    this.WorkingStorage == input.WorkingStorage ||
                    (this.WorkingStorage != null &&
                    this.WorkingStorage.Equals(input.WorkingStorage))
                ) && 
                (
                    this.CalculationDateTime == input.CalculationDateTime ||
                    (this.CalculationDateTime != null &&
                    this.CalculationDateTime.Equals(input.CalculationDateTime))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.PointsInTimeTotalBytes != null)
                    hashCode = hashCode * 59 + this.PointsInTimeTotalBytes.GetHashCode();
                if (this.RunningMachinesTotalBytes != null)
                    hashCode = hashCode * 59 + this.RunningMachinesTotalBytes.GetHashCode();
                if (this.WorkingStorage != null)
                    hashCode = hashCode * 59 + this.WorkingStorage.GetHashCode();
                if (this.CalculationDateTime != null)
                    hashCode = hashCode * 59 + this.CalculationDateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}