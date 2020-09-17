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
    /// UserReport
    /// </summary>
    [DataContract]
        public partial class UserReport :  IEquatable<UserReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserReport" /> class.
        /// </summary>
        /// <param name="nProtectedMachines">nProtectedMachines.</param>
        /// <param name="projectName">projectName.</param>
        /// <param name="isActivated">isActivated.</param>
        /// <param name="nLicenseUsages">nLicenseUsages.</param>
        /// <param name="gcpMachinesFinanceData">gcpMachinesFinanceData.</param>
        /// <param name="totalTestedOrCutover">totalTestedOrCutover.</param>
        /// <param name="ownerName">ownerName.</param>
        /// <param name="nLaggingMachines">nLaggingMachines.</param>
        /// <param name="nActiveTargetMachines">nActiveTargetMachines.</param>
        /// <param name="nTestMachines">nTestMachines.</param>
        public UserReport(int? nProtectedMachines = default(int?), string projectName = default(string), bool? isActivated = default(bool?), int? nLicenseUsages = default(int?), UserReportGcpMachinesFinanceData gcpMachinesFinanceData = default(UserReportGcpMachinesFinanceData), int? totalTestedOrCutover = default(int?), string ownerName = default(string), int? nLaggingMachines = default(int?), int? nActiveTargetMachines = default(int?), int? nTestMachines = default(int?))
        {
            this.NProtectedMachines = nProtectedMachines;
            this.ProjectName = projectName;
            this.IsActivated = isActivated;
            this.NLicenseUsages = nLicenseUsages;
            this.GcpMachinesFinanceData = gcpMachinesFinanceData;
            this.TotalTestedOrCutover = totalTestedOrCutover;
            this.OwnerName = ownerName;
            this.NLaggingMachines = nLaggingMachines;
            this.NActiveTargetMachines = nActiveTargetMachines;
            this.NTestMachines = nTestMachines;
        }
        
        /// <summary>
        /// Gets or Sets NProtectedMachines
        /// </summary>
        [DataMember(Name="n_protected_machines", EmitDefaultValue=false)]
        public int? NProtectedMachines { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name="project_name", EmitDefaultValue=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or Sets IsActivated
        /// </summary>
        [DataMember(Name="is_activated", EmitDefaultValue=false)]
        public bool? IsActivated { get; set; }

        /// <summary>
        /// Gets or Sets NLicenseUsages
        /// </summary>
        [DataMember(Name="n_license_usages", EmitDefaultValue=false)]
        public int? NLicenseUsages { get; set; }

        /// <summary>
        /// Gets or Sets GcpMachinesFinanceData
        /// </summary>
        [DataMember(Name="gcp_machines_finance_data", EmitDefaultValue=false)]
        public UserReportGcpMachinesFinanceData GcpMachinesFinanceData { get; set; }

        /// <summary>
        /// Gets or Sets TotalTestedOrCutover
        /// </summary>
        [DataMember(Name="total_tested_or_cutover", EmitDefaultValue=false)]
        public int? TotalTestedOrCutover { get; set; }

        /// <summary>
        /// Gets or Sets OwnerName
        /// </summary>
        [DataMember(Name="owner_name", EmitDefaultValue=false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or Sets NLaggingMachines
        /// </summary>
        [DataMember(Name="n_lagging_machines", EmitDefaultValue=false)]
        public int? NLaggingMachines { get; set; }

        /// <summary>
        /// Gets or Sets NActiveTargetMachines
        /// </summary>
        [DataMember(Name="n_active_target_machines", EmitDefaultValue=false)]
        public int? NActiveTargetMachines { get; set; }

        /// <summary>
        /// Gets or Sets NTestMachines
        /// </summary>
        [DataMember(Name="n_test_machines", EmitDefaultValue=false)]
        public int? NTestMachines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserReport {\n");
            sb.Append("  NProtectedMachines: ").Append(NProtectedMachines).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  IsActivated: ").Append(IsActivated).Append("\n");
            sb.Append("  NLicenseUsages: ").Append(NLicenseUsages).Append("\n");
            sb.Append("  GcpMachinesFinanceData: ").Append(GcpMachinesFinanceData).Append("\n");
            sb.Append("  TotalTestedOrCutover: ").Append(TotalTestedOrCutover).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  NLaggingMachines: ").Append(NLaggingMachines).Append("\n");
            sb.Append("  NActiveTargetMachines: ").Append(NActiveTargetMachines).Append("\n");
            sb.Append("  NTestMachines: ").Append(NTestMachines).Append("\n");
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
            return this.Equals(input as UserReport);
        }

        /// <summary>
        /// Returns true if UserReport instances are equal
        /// </summary>
        /// <param name="input">Instance of UserReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NProtectedMachines == input.NProtectedMachines ||
                    (this.NProtectedMachines != null &&
                    this.NProtectedMachines.Equals(input.NProtectedMachines))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.IsActivated == input.IsActivated ||
                    (this.IsActivated != null &&
                    this.IsActivated.Equals(input.IsActivated))
                ) && 
                (
                    this.NLicenseUsages == input.NLicenseUsages ||
                    (this.NLicenseUsages != null &&
                    this.NLicenseUsages.Equals(input.NLicenseUsages))
                ) && 
                (
                    this.GcpMachinesFinanceData == input.GcpMachinesFinanceData ||
                    (this.GcpMachinesFinanceData != null &&
                    this.GcpMachinesFinanceData.Equals(input.GcpMachinesFinanceData))
                ) && 
                (
                    this.TotalTestedOrCutover == input.TotalTestedOrCutover ||
                    (this.TotalTestedOrCutover != null &&
                    this.TotalTestedOrCutover.Equals(input.TotalTestedOrCutover))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.NLaggingMachines == input.NLaggingMachines ||
                    (this.NLaggingMachines != null &&
                    this.NLaggingMachines.Equals(input.NLaggingMachines))
                ) && 
                (
                    this.NActiveTargetMachines == input.NActiveTargetMachines ||
                    (this.NActiveTargetMachines != null &&
                    this.NActiveTargetMachines.Equals(input.NActiveTargetMachines))
                ) && 
                (
                    this.NTestMachines == input.NTestMachines ||
                    (this.NTestMachines != null &&
                    this.NTestMachines.Equals(input.NTestMachines))
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
                if (this.NProtectedMachines != null)
                    hashCode = hashCode * 59 + this.NProtectedMachines.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.IsActivated != null)
                    hashCode = hashCode * 59 + this.IsActivated.GetHashCode();
                if (this.NLicenseUsages != null)
                    hashCode = hashCode * 59 + this.NLicenseUsages.GetHashCode();
                if (this.GcpMachinesFinanceData != null)
                    hashCode = hashCode * 59 + this.GcpMachinesFinanceData.GetHashCode();
                if (this.TotalTestedOrCutover != null)
                    hashCode = hashCode * 59 + this.TotalTestedOrCutover.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.NLaggingMachines != null)
                    hashCode = hashCode * 59 + this.NLaggingMachines.GetHashCode();
                if (this.NActiveTargetMachines != null)
                    hashCode = hashCode * 59 + this.NActiveTargetMachines.GetHashCode();
                if (this.NTestMachines != null)
                    hashCode = hashCode * 59 + this.NTestMachines.GetHashCode();
                return hashCode;
            }
        }
    }
}