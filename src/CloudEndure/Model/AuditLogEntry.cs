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
    /// A single entry in the audit log
    /// </summary>
    [DataContract]
        public partial class AuditLogEntry :  IEquatable<AuditLogEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEntry" /> class.
        /// </summary>
        /// <param name="username">username (typically an email) of user who initiated action (in UI or via API) which resulted in this audit log entry being added. .</param>
        /// <param name="eventName">Unique event name.  One of:  - replicationConfigurationChanged  - blueprintChanged .</param>
        /// <param name="participatingMachines">List of machine-identifiers objects.  Only present if Audit Log entry relates to one or more machines. .</param>
        /// <param name="description">Long-form human-readable description of Audit Log entry..</param>
        /// <param name="changedFields">Map of fields that have been changed and their old an new values. Only present when eventName is replicationConfigurationChanged or blueprintChanged .</param>
        /// <param name="timestamp">RFC 3339 compliant date-time string of when Audit Log entry was created/ event described by audit log entry happened. .</param>
        /// <param name="jobId">ID of Job due to which this log entry was created (only included if log entry is result of a Job).</param>
        public AuditLogEntry(string username = default(string), string eventName = default(string), List<AuditLogEntryParticipatingMachines> participatingMachines = default(List<AuditLogEntryParticipatingMachines>), string description = default(string), List<AuditLogChangedField> changedFields = default(List<AuditLogChangedField>), DateTime? timestamp = default(DateTime?), string jobId = default(string))
        {
            this.Username = username;
            this.EventName = eventName;
            this.ParticipatingMachines = participatingMachines;
            this.Description = description;
            this.ChangedFields = changedFields;
            this.Timestamp = timestamp;
            this.JobId = jobId;
        }
        
        /// <summary>
        /// username (typically an email) of user who initiated action (in UI or via API) which resulted in this audit log entry being added. 
        /// </summary>
        /// <value>username (typically an email) of user who initiated action (in UI or via API) which resulted in this audit log entry being added. </value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Unique event name.  One of:  - replicationConfigurationChanged  - blueprintChanged 
        /// </summary>
        /// <value>Unique event name.  One of:  - replicationConfigurationChanged  - blueprintChanged </value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// List of machine-identifiers objects.  Only present if Audit Log entry relates to one or more machines. 
        /// </summary>
        /// <value>List of machine-identifiers objects.  Only present if Audit Log entry relates to one or more machines. </value>
        [DataMember(Name="participatingMachines", EmitDefaultValue=false)]
        public List<AuditLogEntryParticipatingMachines> ParticipatingMachines { get; set; }

        /// <summary>
        /// Long-form human-readable description of Audit Log entry.
        /// </summary>
        /// <value>Long-form human-readable description of Audit Log entry.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Map of fields that have been changed and their old an new values. Only present when eventName is replicationConfigurationChanged or blueprintChanged 
        /// </summary>
        /// <value>Map of fields that have been changed and their old an new values. Only present when eventName is replicationConfigurationChanged or blueprintChanged </value>
        [DataMember(Name="changedFields", EmitDefaultValue=false)]
        public List<AuditLogChangedField> ChangedFields { get; set; }

        /// <summary>
        /// RFC 3339 compliant date-time string of when Audit Log entry was created/ event described by audit log entry happened. 
        /// </summary>
        /// <value>RFC 3339 compliant date-time string of when Audit Log entry was created/ event described by audit log entry happened. </value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// ID of Job due to which this log entry was created (only included if log entry is result of a Job)
        /// </summary>
        /// <value>ID of Job due to which this log entry was created (only included if log entry is result of a Job)</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditLogEntry {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  ParticipatingMachines: ").Append(ParticipatingMachines).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ChangedFields: ").Append(ChangedFields).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
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
            return this.Equals(input as AuditLogEntry);
        }

        /// <summary>
        /// Returns true if AuditLogEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditLogEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditLogEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.ParticipatingMachines == input.ParticipatingMachines ||
                    this.ParticipatingMachines != null &&
                    input.ParticipatingMachines != null &&
                    this.ParticipatingMachines.SequenceEqual(input.ParticipatingMachines)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ChangedFields == input.ChangedFields ||
                    this.ChangedFields != null &&
                    input.ChangedFields != null &&
                    this.ChangedFields.SequenceEqual(input.ChangedFields)
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.ParticipatingMachines != null)
                    hashCode = hashCode * 59 + this.ParticipatingMachines.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ChangedFields != null)
                    hashCode = hashCode * 59 + this.ChangedFields.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
