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
    /// A Batch operation result object - The machine objects for which the operation succeeded, and the IDs of the machines for which the operation failed.
    /// </summary>
    [DataContract]
        public partial class MachinesListInvalidIDsAndJob :  IEquatable<MachinesListInvalidIDsAndJob>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MachinesListInvalidIDsAndJob" /> class.
        /// </summary>
        /// <param name="items">items.</param>
        /// <param name="job">job.</param>
        /// <param name="invalidMachineIDs">The IDs of the machines for which the operation failed..</param>
        public MachinesListInvalidIDsAndJob(List<Machine> items = default(List<Machine>), Job job = default(Job), List<string> invalidMachineIDs = default(List<string>))
        {
            this.Items = items;
            this.Job = job;
            this.InvalidMachineIDs = invalidMachineIDs;
        }
        
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<Machine> Items { get; set; }

        /// <summary>
        /// Gets or Sets Job
        /// </summary>
        [DataMember(Name="job", EmitDefaultValue=false)]
        public Job Job { get; set; }

        /// <summary>
        /// The IDs of the machines for which the operation failed.
        /// </summary>
        /// <value>The IDs of the machines for which the operation failed.</value>
        [DataMember(Name="invalidMachineIDs", EmitDefaultValue=false)]
        public List<string> InvalidMachineIDs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MachinesListInvalidIDsAndJob {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  InvalidMachineIDs: ").Append(InvalidMachineIDs).Append("\n");
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
            return this.Equals(input as MachinesListInvalidIDsAndJob);
        }

        /// <summary>
        /// Returns true if MachinesListInvalidIDsAndJob instances are equal
        /// </summary>
        /// <param name="input">Instance of MachinesListInvalidIDsAndJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MachinesListInvalidIDsAndJob input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Job == input.Job ||
                    (this.Job != null &&
                    this.Job.Equals(input.Job))
                ) && 
                (
                    this.InvalidMachineIDs == input.InvalidMachineIDs ||
                    this.InvalidMachineIDs != null &&
                    input.InvalidMachineIDs != null &&
                    this.InvalidMachineIDs.SequenceEqual(input.InvalidMachineIDs)
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Job != null)
                    hashCode = hashCode * 59 + this.Job.GetHashCode();
                if (this.InvalidMachineIDs != null)
                    hashCode = hashCode * 59 + this.InvalidMachineIDs.GetHashCode();
                return hashCode;
            }
        }
    }
}
