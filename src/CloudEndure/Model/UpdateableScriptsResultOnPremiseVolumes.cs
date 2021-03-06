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
    /// UpdateableScriptsResultOnPremiseVolumes
    /// </summary>
    [DataContract]
        public partial class UpdateableScriptsResultOnPremiseVolumes :  IEquatable<UpdateableScriptsResultOnPremiseVolumes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateableScriptsResultOnPremiseVolumes" /> class.
        /// </summary>
        /// <param name="device">device.</param>
        /// <param name="volId">volId.</param>
        /// <param name="size">size.</param>
        public UpdateableScriptsResultOnPremiseVolumes(string device = default(string), string volId = default(string), int? size = default(int?))
        {
            this.Device = device;
            this.VolId = volId;
            this.Size = size;
        }
        
        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public string Device { get; set; }

        /// <summary>
        /// Gets or Sets VolId
        /// </summary>
        [DataMember(Name="vol_id", EmitDefaultValue=false)]
        public string VolId { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateableScriptsResultOnPremiseVolumes {\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  VolId: ").Append(VolId).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as UpdateableScriptsResultOnPremiseVolumes);
        }

        /// <summary>
        /// Returns true if UpdateableScriptsResultOnPremiseVolumes instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateableScriptsResultOnPremiseVolumes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateableScriptsResultOnPremiseVolumes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.VolId == input.VolId ||
                    (this.VolId != null &&
                    this.VolId.Equals(input.VolId))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.VolId != null)
                    hashCode = hashCode * 59 + this.VolId.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
