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
    /// ProjectStorageWorkingStorage
    /// </summary>
    [DataContract]
        public partial class ProjectStorageWorkingStorage :  IEquatable<ProjectStorageWorkingStorage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStorageWorkingStorage" /> class.
        /// </summary>
        /// <param name="disksTotalBytes">disksTotalBytes.</param>
        /// <param name="snapshotsTotalBytes">snapshotsTotalBytes.</param>
        public ProjectStorageWorkingStorage(long? disksTotalBytes = default(long?), long? snapshotsTotalBytes = default(long?))
        {
            this.DisksTotalBytes = disksTotalBytes;
            this.SnapshotsTotalBytes = snapshotsTotalBytes;
        }
        
        /// <summary>
        /// Gets or Sets DisksTotalBytes
        /// </summary>
        [DataMember(Name="disksTotalBytes", EmitDefaultValue=false)]
        public long? DisksTotalBytes { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotsTotalBytes
        /// </summary>
        [DataMember(Name="snapshotsTotalBytes", EmitDefaultValue=false)]
        public long? SnapshotsTotalBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectStorageWorkingStorage {\n");
            sb.Append("  DisksTotalBytes: ").Append(DisksTotalBytes).Append("\n");
            sb.Append("  SnapshotsTotalBytes: ").Append(SnapshotsTotalBytes).Append("\n");
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
            return this.Equals(input as ProjectStorageWorkingStorage);
        }

        /// <summary>
        /// Returns true if ProjectStorageWorkingStorage instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectStorageWorkingStorage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectStorageWorkingStorage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisksTotalBytes == input.DisksTotalBytes ||
                    (this.DisksTotalBytes != null &&
                    this.DisksTotalBytes.Equals(input.DisksTotalBytes))
                ) && 
                (
                    this.SnapshotsTotalBytes == input.SnapshotsTotalBytes ||
                    (this.SnapshotsTotalBytes != null &&
                    this.SnapshotsTotalBytes.Equals(input.SnapshotsTotalBytes))
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
                if (this.DisksTotalBytes != null)
                    hashCode = hashCode * 59 + this.DisksTotalBytes.GetHashCode();
                if (this.SnapshotsTotalBytes != null)
                    hashCode = hashCode * 59 + this.SnapshotsTotalBytes.GetHashCode();
                return hashCode;
            }
        }
    }
}
