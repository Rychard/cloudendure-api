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
    /// MachineReplicationInfoInitiationStates
    /// </summary>
    [DataContract]
        public partial class MachineReplicationInfoInitiationStates :  IEquatable<MachineReplicationInfoInitiationStates>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MachineReplicationInfoInitiationStates" /> class.
        /// </summary>
        /// <param name="items">A collection of replication initiation attempts in chronological order..</param>
        /// <param name="estimatedNextAttemptDateTime">In case replication is not currently active - An estimate on when its initiation will next be attempted..</param>
        public MachineReplicationInfoInitiationStates(List<MachineReplicationInfoInitiationStatesItems> items = default(List<MachineReplicationInfoInitiationStatesItems>), DateTime? estimatedNextAttemptDateTime = default(DateTime?))
        {
            this.Items = items;
            this.EstimatedNextAttemptDateTime = estimatedNextAttemptDateTime;
        }
        
        /// <summary>
        /// A collection of replication initiation attempts in chronological order.
        /// </summary>
        /// <value>A collection of replication initiation attempts in chronological order.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<MachineReplicationInfoInitiationStatesItems> Items { get; set; }

        /// <summary>
        /// In case replication is not currently active - An estimate on when its initiation will next be attempted.
        /// </summary>
        /// <value>In case replication is not currently active - An estimate on when its initiation will next be attempted.</value>
        [DataMember(Name="estimatedNextAttemptDateTime", EmitDefaultValue=false)]
        public DateTime? EstimatedNextAttemptDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MachineReplicationInfoInitiationStates {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  EstimatedNextAttemptDateTime: ").Append(EstimatedNextAttemptDateTime).Append("\n");
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
            return this.Equals(input as MachineReplicationInfoInitiationStates);
        }

        /// <summary>
        /// Returns true if MachineReplicationInfoInitiationStates instances are equal
        /// </summary>
        /// <param name="input">Instance of MachineReplicationInfoInitiationStates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MachineReplicationInfoInitiationStates input)
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
                    this.EstimatedNextAttemptDateTime == input.EstimatedNextAttemptDateTime ||
                    (this.EstimatedNextAttemptDateTime != null &&
                    this.EstimatedNextAttemptDateTime.Equals(input.EstimatedNextAttemptDateTime))
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
                if (this.EstimatedNextAttemptDateTime != null)
                    hashCode = hashCode * 59 + this.EstimatedNextAttemptDateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
