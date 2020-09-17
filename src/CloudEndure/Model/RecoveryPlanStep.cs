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
    /// Recovery plan step
    /// </summary>
    [DataContract]
        public partial class RecoveryPlanStep :  IEquatable<RecoveryPlanStep>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoveryPlanStep" /> class.
        /// </summary>
        /// <param name="machineIDs">machineIDs.</param>
        /// <param name="waitBefore">waitBefore.</param>
        /// <param name="name">name.</param>
        public RecoveryPlanStep(List<string> machineIDs = default(List<string>), string waitBefore = default(string), string name = default(string))
        {
            this.MachineIDs = machineIDs;
            this.WaitBefore = waitBefore;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets MachineIDs
        /// </summary>
        [DataMember(Name="machineIDs", EmitDefaultValue=false)]
        public List<string> MachineIDs { get; set; }

        /// <summary>
        /// Gets or Sets WaitBefore
        /// </summary>
        [DataMember(Name="waitBefore", EmitDefaultValue=false)]
        public string WaitBefore { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecoveryPlanStep {\n");
            sb.Append("  MachineIDs: ").Append(MachineIDs).Append("\n");
            sb.Append("  WaitBefore: ").Append(WaitBefore).Append("\n");
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
            return this.Equals(input as RecoveryPlanStep);
        }

        /// <summary>
        /// Returns true if RecoveryPlanStep instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoveryPlanStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoveryPlanStep input)
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
                    this.WaitBefore == input.WaitBefore ||
                    (this.WaitBefore != null &&
                    this.WaitBefore.Equals(input.WaitBefore))
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
                if (this.MachineIDs != null)
                    hashCode = hashCode * 59 + this.MachineIDs.GetHashCode();
                if (this.WaitBefore != null)
                    hashCode = hashCode * 59 + this.WaitBefore.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}