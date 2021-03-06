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
    /// Contains the account identifier which is referenced by other resources, as well as feature information for the account.
    /// </summary>
    [DataContract]
        public partial class Account :  IEquatable<Account>
    {
        /// <summary>
        /// Defines DefaultLicenseType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DefaultLicenseTypeEnum
        {
            /// <summary>
            /// Enum MIGRATION for value: MIGRATION
            /// </summary>
            [EnumMember(Value = "MIGRATION")]
            MIGRATION = 1,
            /// <summary>
            /// Enum DR for value: DR
            /// </summary>
            [EnumMember(Value = "DR")]
            DR = 2,
            /// <summary>
            /// Enum DRTRIAL for value: DR_TRIAL
            /// </summary>
            [EnumMember(Value = "DR_TRIAL")]
            DRTRIAL = 3,
            /// <summary>
            /// Enum BACKUP for value: BACKUP
            /// </summary>
            [EnumMember(Value = "BACKUP")]
            BACKUP = 4        }
        /// <summary>
        /// Gets or Sets DefaultLicenseType
        /// </summary>
        [DataMember(Name="defaultLicenseType", EmitDefaultValue=false)]
        public DefaultLicenseTypeEnum? DefaultLicenseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="targetCredentialsApi">used to enable targetCloudCredentials. This API should be replaced soon..</param>
        /// <param name="allowArchivingDefaultValue">allowArchivingDefaultValue.</param>
        /// <param name="perAccountUserPool">perAccountUserPool.</param>
        /// <param name="isMedOne">isMedOne.</param>
        /// <param name="inviteTokenExpiryMinutes">inviteTokenExpiryMinutes.</param>
        /// <param name="samlSettings">samlSettings.</param>
        /// <param name="isRightSizingEnabled">isRightSizingEnabled.</param>
        /// <param name="maxProjectsAllowed">maxProjectsAllowed.</param>
        /// <param name="ceAdminProperties">ceAdminProperties.</param>
        /// <param name="ownerId">Account Owner (a User).</param>
        public Account(bool? targetCredentialsApi = default(bool?), bool? allowArchivingDefaultValue = default(bool?), bool? perAccountUserPool = default(bool?), bool? isMedOne = default(bool?), int? inviteTokenExpiryMinutes = default(int?), SamlSettings samlSettings = default(SamlSettings), bool? isRightSizingEnabled = default(bool?), int? maxProjectsAllowed = default(int?), AccountCeAdminProperties ceAdminProperties = default(AccountCeAdminProperties), string ownerId = default(string))
        {
            this.TargetCredentialsApi = targetCredentialsApi;
            this.AllowArchivingDefaultValue = allowArchivingDefaultValue;
            this.PerAccountUserPool = perAccountUserPool;
            this.IsMedOne = isMedOne;
            this.InviteTokenExpiryMinutes = inviteTokenExpiryMinutes;
            this.SamlSettings = samlSettings;
            this.IsRightSizingEnabled = isRightSizingEnabled;
            this.MaxProjectsAllowed = maxProjectsAllowed;
            this.CeAdminProperties = ceAdminProperties;
            this.OwnerId = ownerId;
        }
        
        /// <summary>
        /// used to enable targetCloudCredentials. This API should be replaced soon.
        /// </summary>
        /// <value>used to enable targetCloudCredentials. This API should be replaced soon.</value>
        [DataMember(Name="targetCredentialsApi", EmitDefaultValue=false)]
        public bool? TargetCredentialsApi { get; set; }

        /// <summary>
        /// Gets or Sets AllowArchivingDefaultValue
        /// </summary>
        [DataMember(Name="allowArchivingDefaultValue", EmitDefaultValue=false)]
        public bool? AllowArchivingDefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets PerAccountUserPool
        /// </summary>
        [DataMember(Name="perAccountUserPool", EmitDefaultValue=false)]
        public bool? PerAccountUserPool { get; set; }


        /// <summary>
        /// Gets or Sets IsMedOne
        /// </summary>
        [DataMember(Name="isMedOne", EmitDefaultValue=false)]
        public bool? IsMedOne { get; set; }

        /// <summary>
        /// UUID of the account
        /// </summary>
        /// <value>UUID of the account</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets InviteTokenExpiryMinutes
        /// </summary>
        [DataMember(Name="inviteTokenExpiryMinutes", EmitDefaultValue=false)]
        public int? InviteTokenExpiryMinutes { get; set; }

        /// <summary>
        /// Gets or Sets IsGcpSelfService
        /// </summary>
        [DataMember(Name="isGcpSelfService", EmitDefaultValue=false)]
        public bool? IsGcpSelfService { get; private set; }

        /// <summary>
        /// Gets or Sets IsDrTrial
        /// </summary>
        [DataMember(Name="isDrTrial", EmitDefaultValue=false)]
        public bool? IsDrTrial { get; private set; }

        /// <summary>
        /// Gets or Sets IsArmSelfService
        /// </summary>
        [DataMember(Name="isArmSelfService", EmitDefaultValue=false)]
        public bool? IsArmSelfService { get; private set; }

        /// <summary>
        /// Gets or Sets IsAwsSelfService
        /// </summary>
        [DataMember(Name="isAwsSelfService", EmitDefaultValue=false)]
        public bool? IsAwsSelfService { get; private set; }

        /// <summary>
        /// Gets or Sets SamlSettings
        /// </summary>
        [DataMember(Name="samlSettings", EmitDefaultValue=false)]
        public SamlSettings SamlSettings { get; set; }

        /// <summary>
        /// Gets or Sets IsRightSizingEnabled
        /// </summary>
        [DataMember(Name="isRightSizingEnabled", EmitDefaultValue=false)]
        public bool? IsRightSizingEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MaxProjectsAllowed
        /// </summary>
        [DataMember(Name="maxProjectsAllowed", EmitDefaultValue=false)]
        public int? MaxProjectsAllowed { get; set; }

        /// <summary>
        /// Gets or Sets CeAdminProperties
        /// </summary>
        [DataMember(Name="ceAdminProperties", EmitDefaultValue=false)]
        public AccountCeAdminProperties CeAdminProperties { get; set; }

        /// <summary>
        /// Account Owner (a User)
        /// </summary>
        /// <value>Account Owner (a User)</value>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  TargetCredentialsApi: ").Append(TargetCredentialsApi).Append("\n");
            sb.Append("  AllowArchivingDefaultValue: ").Append(AllowArchivingDefaultValue).Append("\n");
            sb.Append("  PerAccountUserPool: ").Append(PerAccountUserPool).Append("\n");
            sb.Append("  DefaultLicenseType: ").Append(DefaultLicenseType).Append("\n");
            sb.Append("  IsMedOne: ").Append(IsMedOne).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InviteTokenExpiryMinutes: ").Append(InviteTokenExpiryMinutes).Append("\n");
            sb.Append("  IsGcpSelfService: ").Append(IsGcpSelfService).Append("\n");
            sb.Append("  IsDrTrial: ").Append(IsDrTrial).Append("\n");
            sb.Append("  IsArmSelfService: ").Append(IsArmSelfService).Append("\n");
            sb.Append("  IsAwsSelfService: ").Append(IsAwsSelfService).Append("\n");
            sb.Append("  SamlSettings: ").Append(SamlSettings).Append("\n");
            sb.Append("  IsRightSizingEnabled: ").Append(IsRightSizingEnabled).Append("\n");
            sb.Append("  MaxProjectsAllowed: ").Append(MaxProjectsAllowed).Append("\n");
            sb.Append("  CeAdminProperties: ").Append(CeAdminProperties).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetCredentialsApi == input.TargetCredentialsApi ||
                    (this.TargetCredentialsApi != null &&
                    this.TargetCredentialsApi.Equals(input.TargetCredentialsApi))
                ) && 
                (
                    this.AllowArchivingDefaultValue == input.AllowArchivingDefaultValue ||
                    (this.AllowArchivingDefaultValue != null &&
                    this.AllowArchivingDefaultValue.Equals(input.AllowArchivingDefaultValue))
                ) && 
                (
                    this.PerAccountUserPool == input.PerAccountUserPool ||
                    (this.PerAccountUserPool != null &&
                    this.PerAccountUserPool.Equals(input.PerAccountUserPool))
                ) && 
                (
                    this.DefaultLicenseType == input.DefaultLicenseType ||
                    (this.DefaultLicenseType != null &&
                    this.DefaultLicenseType.Equals(input.DefaultLicenseType))
                ) && 
                (
                    this.IsMedOne == input.IsMedOne ||
                    (this.IsMedOne != null &&
                    this.IsMedOne.Equals(input.IsMedOne))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InviteTokenExpiryMinutes == input.InviteTokenExpiryMinutes ||
                    (this.InviteTokenExpiryMinutes != null &&
                    this.InviteTokenExpiryMinutes.Equals(input.InviteTokenExpiryMinutes))
                ) && 
                (
                    this.IsGcpSelfService == input.IsGcpSelfService ||
                    (this.IsGcpSelfService != null &&
                    this.IsGcpSelfService.Equals(input.IsGcpSelfService))
                ) && 
                (
                    this.IsDrTrial == input.IsDrTrial ||
                    (this.IsDrTrial != null &&
                    this.IsDrTrial.Equals(input.IsDrTrial))
                ) && 
                (
                    this.IsArmSelfService == input.IsArmSelfService ||
                    (this.IsArmSelfService != null &&
                    this.IsArmSelfService.Equals(input.IsArmSelfService))
                ) && 
                (
                    this.IsAwsSelfService == input.IsAwsSelfService ||
                    (this.IsAwsSelfService != null &&
                    this.IsAwsSelfService.Equals(input.IsAwsSelfService))
                ) && 
                (
                    this.SamlSettings == input.SamlSettings ||
                    (this.SamlSettings != null &&
                    this.SamlSettings.Equals(input.SamlSettings))
                ) && 
                (
                    this.IsRightSizingEnabled == input.IsRightSizingEnabled ||
                    (this.IsRightSizingEnabled != null &&
                    this.IsRightSizingEnabled.Equals(input.IsRightSizingEnabled))
                ) && 
                (
                    this.MaxProjectsAllowed == input.MaxProjectsAllowed ||
                    (this.MaxProjectsAllowed != null &&
                    this.MaxProjectsAllowed.Equals(input.MaxProjectsAllowed))
                ) && 
                (
                    this.CeAdminProperties == input.CeAdminProperties ||
                    (this.CeAdminProperties != null &&
                    this.CeAdminProperties.Equals(input.CeAdminProperties))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
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
                if (this.TargetCredentialsApi != null)
                    hashCode = hashCode * 59 + this.TargetCredentialsApi.GetHashCode();
                if (this.AllowArchivingDefaultValue != null)
                    hashCode = hashCode * 59 + this.AllowArchivingDefaultValue.GetHashCode();
                if (this.PerAccountUserPool != null)
                    hashCode = hashCode * 59 + this.PerAccountUserPool.GetHashCode();
                if (this.DefaultLicenseType != null)
                    hashCode = hashCode * 59 + this.DefaultLicenseType.GetHashCode();
                if (this.IsMedOne != null)
                    hashCode = hashCode * 59 + this.IsMedOne.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InviteTokenExpiryMinutes != null)
                    hashCode = hashCode * 59 + this.InviteTokenExpiryMinutes.GetHashCode();
                if (this.IsGcpSelfService != null)
                    hashCode = hashCode * 59 + this.IsGcpSelfService.GetHashCode();
                if (this.IsDrTrial != null)
                    hashCode = hashCode * 59 + this.IsDrTrial.GetHashCode();
                if (this.IsArmSelfService != null)
                    hashCode = hashCode * 59 + this.IsArmSelfService.GetHashCode();
                if (this.IsAwsSelfService != null)
                    hashCode = hashCode * 59 + this.IsAwsSelfService.GetHashCode();
                if (this.SamlSettings != null)
                    hashCode = hashCode * 59 + this.SamlSettings.GetHashCode();
                if (this.IsRightSizingEnabled != null)
                    hashCode = hashCode * 59 + this.IsRightSizingEnabled.GetHashCode();
                if (this.MaxProjectsAllowed != null)
                    hashCode = hashCode * 59 + this.MaxProjectsAllowed.GetHashCode();
                if (this.CeAdminProperties != null)
                    hashCode = hashCode * 59 + this.CeAdminProperties.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
