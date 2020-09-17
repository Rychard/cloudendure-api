# CloudEndure API - C# Client

## Basic Usage

- Add the following using statements:

  ```csharp
  using CloudEndure.Api
  using CloudEndure.Client
  using CloudEndure.Model
  ```

- Add the `FubarCoder.RestSharp.Portable.HttpClient` NuGet package

- Use this sample code as a reference:

  ```csharp
  // Create a new configuration object so that we can share it across our API instances
  Configuration configuration = new Configuration();

  // By default it targets /api/latest/ but the website seems to use /api/v5/
  // Honestly, it's probably safer to explicitly set the version.
  configuration.BasePath = "https://console.cloudendure.com/api/v5";

  // Create instances of the API classes you intend to use
  // At a minimum, you need an instance of AuthenticationApi
  // Make sure to provide a common Configuration instance in the constructor!
  var apiAuth = new AuthenticationApi(configuration);
  var apiProjects = new ProjectApi(configuration);
  var apiMachines = new MachinesApi(configuration);

  // We need access to the cookie container used by the internal RestSharp instance
  // We'll just create our own and then assign it to the underlying object.
  var cookieContainer = new System.Net.CookieContainer();
  configuration.ApiClient.RestClient.CookieContainer = cookieContainer;

  // Before you can make any API calls, you have to login first.
  var resultAuth = await apiAuth.LoginPostAsync(new Body1 { UserApiToken = apiToken });

  // The official API documentation says that the response from the /Login endpoint returns a cookie
  // It does, but the cookie doesn't actually work for authentication; all methods return HTTP 403 Unauthorized.
  // After some digging, I determined that the API doesn't expect a cookie, it expects a custom HTTP header.
  // The name of the custom header is SIMILAR to the cookie, but prefixed with "X-"
  // That said, we now have to enumerate the cookies and copy the value of the "XSRF-TOKEN" cookie.
  // We'll add a default header to our shared Configuration object so that it's passed to all subsequent API calls
  var cookies = cookieContainer.GetCookies(new Uri("https://console.cloudendure.com/"));
  foreach (Cookie cookie in cookies)
  {
      if(cookie.Name != "XSRF-TOKEN") { continue; }
      configuration.AddDefaultHeader("X-XSRF-TOKEN", cookie.Value);
  }

  // From here on out, you should be able to call all the API endpoints.
  // I didn't test them all, so you're on your own.
  var projectResult = await apiProjects.ProjectsGetAsync();
  ```

## General

- Request authentication in CloudEndure's API is done using session cookies.
- A session cookie is returned upon successful execution of the "login" method.
- This value must then be provided within the request headers of all subsequent API requests.

**NOTICE: The above bullet points regarding authentication are incorrect!**

## Errors

Some errors are not specifically written in every method since they may always return. Those are:

- `401` (Unauthorized) - for unauthenticated requests.
- `405` (Method Not Allowed) - for using a method that is not supported (POST instead of GET).
- `403` (Forbidden) - request is authenticated, but the user is not allowed to access.
- `422` (Unprocessable Entity) - for invalid input.

## Formats

All strings with date-time format are according to RFC3339.  All strings with "duration" format are according to ISO8601. For example, a full day duration can be specified with "PNNNND".

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 5
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen
  - For more information, please visit [https://bit.ly/2T54hSc](https://bit.ly/2T54hSc)

## Frameworks supported

- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

## Dependencies

- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

## Installation

Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var accountId = accountId_example;  // string |

            try
            {
                // Get Account information
                Account result = apiInstance.AccountsAccountIdGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AccountsAccountIdGet: " + e.Message );
            }
        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://console.cloudendure.com/api/latest*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**AccountsAccountIdGet**](docs/AccountApi.md#accountsaccountidget) | **GET** /accounts/{accountId} | Get Account information
*ActionsApi* | [**ProjectsProjectIdJobsGet**](docs/ActionsApi.md#projectsprojectidjobsget) | **GET** /projects/{projectId}/jobs | List Jobs
*ActionsApi* | [**ProjectsProjectIdJobsJobIdGet**](docs/ActionsApi.md#projectsprojectidjobsjobidget) | **GET** /projects/{projectId}/jobs/{jobId} | Get Job
*ActionsApi* | [**ProjectsProjectIdLaunchMachinesPost**](docs/ActionsApi.md#projectsprojectidlaunchmachinespost) | **POST** /projects/{projectId}/launchMachines | Launch target machines
*ActionsApi* | [**ProjectsProjectIdLaunchRestoreServersPost**](docs/ActionsApi.md#projectsprojectidlaunchrestoreserverspost) | **POST** /projects/{projectId}/launchRestoreServers | Launch restore servers
*ActionsApi* | [**ProjectsProjectIdMoveMachinesPost**](docs/ActionsApi.md#projectsprojectidmovemachinespost) | **POST** /projects/{projectId}/moveMachines | Moves machines to another project
*ActionsApi* | [**ProjectsProjectIdPauseReplicationPost**](docs/ActionsApi.md#projectsprojectidpausereplicationpost) | **POST** /projects/{projectId}/pauseReplication | Pause replication
*ActionsApi* | [**ProjectsProjectIdReplicasDelete**](docs/ActionsApi.md#projectsprojectidreplicasdelete) | **DELETE** /projects/{projectId}/replicas | Perform Cleanup
*ActionsApi* | [**ProjectsProjectIdReverseReplicationPost**](docs/ActionsApi.md#projectsprojectidreversereplicationpost) | **POST** /projects/{projectId}/reverseReplication | Reverse replication direction
*ActionsApi* | [**ProjectsProjectIdStartReplicationPost**](docs/ActionsApi.md#projectsprojectidstartreplicationpost) | **POST** /projects/{projectId}/startReplication | Start replication
*ActionsApi* | [**ProjectsProjectIdStopReplicationPost**](docs/ActionsApi.md#projectsprojectidstopreplicationpost) | **POST** /projects/{projectId}/stopReplication | Stop replication
*AuthenticationApi* | [**LoginPost**](docs/AuthenticationApi.md#loginpost) | **POST** /login | Login
*AuthenticationApi* | [**LogoutPost**](docs/AuthenticationApi.md#logoutpost) | **POST** /logout | Logout
*BlueprintApi* | [**ProjectsProjectIdBlueprintsBlueprintIdGet**](docs/BlueprintApi.md#projectsprojectidblueprintsblueprintidget) | **GET** /projects/{projectId}/blueprints/{blueprintId} | Get Blueprint
*BlueprintApi* | [**ProjectsProjectIdBlueprintsBlueprintIdPatch**](docs/BlueprintApi.md#projectsprojectidblueprintsblueprintidpatch) | **PATCH** /projects/{projectId}/blueprints/{blueprintId} | Configure Blueprint
*BlueprintApi* | [**ProjectsProjectIdBlueprintsGet**](docs/BlueprintApi.md#projectsprojectidblueprintsget) | **GET** /projects/{projectId}/blueprints | List Blueprints
*BlueprintApi* | [**ProjectsProjectIdBlueprintsPost**](docs/BlueprintApi.md#projectsprojectidblueprintspost) | **POST** /projects/{projectId}/blueprints | Create Blueprint
*CloudApi* | [**CloudCredentialsCredsIdRegionsGet**](docs/CloudApi.md#cloudcredentialscredsidregionsget) | **GET** /cloudCredentials/{credsId}/regions | List Regions
*CloudApi* | [**CloudCredentialsCredsIdRegionsRegionIdDelete**](docs/CloudApi.md#cloudcredentialscredsidregionsregioniddelete) | **DELETE** /cloudCredentials/{credsId}/regions/{regionId} | Delete region (VCenter)
*CloudApi* | [**CloudCredentialsCredsIdRegionsRegionIdGet**](docs/CloudApi.md#cloudcredentialscredsidregionsregionidget) | **GET** /cloudCredentials/{credsId}/regions/{regionId} | Get Region
*CloudApi* | [**CloudCredentialsCredsIdRegionsRegionIdPatch**](docs/CloudApi.md#cloudcredentialscredsidregionsregionidpatch) | **PATCH** /cloudCredentials/{credsId}/regions/{regionId} | Patch region (rename)
*CloudApi* | [**CloudsGet**](docs/CloudApi.md#cloudsget) | **GET** /clouds | List Clouds
*CloudCredentialsApi* | [**CloudCredentialsCredsIdGet**](docs/CloudCredentialsApi.md#cloudcredentialscredsidget) | **GET** /cloudCredentials/{credsId} | Get Credentials
*CloudCredentialsApi* | [**CloudCredentialsCredsIdPatch**](docs/CloudCredentialsApi.md#cloudcredentialscredsidpatch) | **PATCH** /cloudCredentials/{credsId} | Change Credentials
*CloudCredentialsApi* | [**CloudCredentialsGet**](docs/CloudCredentialsApi.md#cloudcredentialsget) | **GET** /cloudCredentials | List Credentials
*CloudCredentialsApi* | [**CloudCredentialsPost**](docs/CloudCredentialsApi.md#cloudcredentialspost) | **POST** /cloudCredentials | Create Credentials
*DefaultApi* | [**AccountsAccountIdAccessGet**](docs/DefaultApi.md#accountsaccountidaccessget) | **GET** /accounts/{accountId}/access | get a temporary token by email
*DefaultApi* | [**ExtendedAccountInfoGet**](docs/DefaultApi.md#extendedaccountinfoget) | **GET** /extendedAccountInfo | Returns the extended current account information.
*DefaultApi* | [**ProjectsAssignUsersPost**](docs/DefaultApi.md#projectsassignuserspost) | **POST** /projects/assignUsers | Assign User
*DefaultApi* | [**ProjectsProjectIdAuditLogGet**](docs/DefaultApi.md#projectsprojectidauditlogget) | **GET** /projects/{projectId}/auditLog | Get audit log
*DefaultApi* | [**ProjectsProjectIdMachinesMachineIdForceRescanPost**](docs/DefaultApi.md#projectsprojectidmachinesmachineidforcerescanpost) | **POST** /projects/{projectId}/machines/{machineId}/forceRescan | Force rescan of machine volumes.
*DefaultApi* | [**ProjectsProjectIdStorageGet**](docs/DefaultApi.md#projectsprojectidstorageget) | **GET** /projects/{projectId}/storage | project's storage
*DefaultApi* | [**ProjectsRemoveUsersPost**](docs/DefaultApi.md#projectsremoveuserspost) | **POST** /projects/removeUsers | Remove User
*DefaultApi* | [**ReplaceApiTokenPost**](docs/DefaultApi.md#replaceapitokenpost) | **POST** /replaceApiToken | Replaces API token
*DefaultApi* | [**SetPasswordPost**](docs/DefaultApi.md#setpasswordpost) | **POST** /setPassword | Set password for invited user
*DefaultApi* | [**UsersAssignRolesPost**](docs/DefaultApi.md#usersassignrolespost) | **POST** /users/assignRoles | Add roles to users
*DefaultApi* | [**UsersPost**](docs/DefaultApi.md#userspost) | **POST** /users | Create a new User
*DefaultApi* | [**UsersRevokeRolesPost**](docs/DefaultApi.md#usersrevokerolespost) | **POST** /users/revokeRoles | Revoke roles from users
*LicensingApi* | [**LicensesGet**](docs/LicensingApi.md#licensesget) | **GET** /licenses | List Licenses
*LicensingApi* | [**LicensesLicenseIdGet**](docs/LicensingApi.md#licenseslicenseidget) | **GET** /licenses/{licenseId} | Get License
*MachinesApi* | [**ProjectsProjectIdMachinesDelete**](docs/MachinesApi.md#projectsprojectidmachinesdelete) | **DELETE** /projects/{projectId}/machines | Uninstall multiple agents
*MachinesApi* | [**ProjectsProjectIdMachinesGet**](docs/MachinesApi.md#projectsprojectidmachinesget) | **GET** /projects/{projectId}/machines | List Machines
*MachinesApi* | [**ProjectsProjectIdMachinesMachineIdDelete**](docs/MachinesApi.md#projectsprojectidmachinesmachineiddelete) | **DELETE** /projects/{projectId}/machines/{machineId} | Uninstall agent
*MachinesApi* | [**ProjectsProjectIdMachinesMachineIdGet**](docs/MachinesApi.md#projectsprojectidmachinesmachineidget) | **GET** /projects/{projectId}/machines/{machineId} | Get a specific machine.
*MachinesApi* | [**ProjectsProjectIdMachinesMachineIdPatch**](docs/MachinesApi.md#projectsprojectidmachinesmachineidpatch) | **PATCH** /projects/{projectId}/machines/{machineId} | Update a machine. Accepts only Launch time updates.
*MachinesApi* | [**ProjectsProjectIdMachinesPatch**](docs/MachinesApi.md#projectsprojectidmachinespatch) | **PATCH** /projects/{projectId}/machines | Batch-update multiple machines
*MachinesApi* | [**ProjectsProjectIdReplicasReplicaIdGet**](docs/MachinesApi.md#projectsprojectidreplicasreplicaidget) | **GET** /projects/{projectId}/replicas/{replicaId} | Get Target Machine
*ProjectApi* | [**ProjectsGet**](docs/ProjectApi.md#projectsget) | **GET** /projects | List Projects
*ProjectApi* | [**ProjectsPost**](docs/ProjectApi.md#projectspost) | **POST** /projects | Create Project
*ProjectApi* | [**ProjectsProjectIdDelete**](docs/ProjectApi.md#projectsprojectiddelete) | **DELETE** /projects/{projectId} | Delete Project and all sub-resources including cloud assets other than launched target machines
*ProjectApi* | [**ProjectsProjectIdGet**](docs/ProjectApi.md#projectsprojectidget) | **GET** /projects/{projectId} | Get Project
*ProjectApi* | [**ProjectsProjectIdPatch**](docs/ProjectApi.md#projectsprojectidpatch) | **PATCH** /projects/{projectId} | Update Project (including partial update)
*ProjectApi* | [**ProjectsProjectIdTagsGet**](docs/ProjectApi.md#projectsprojectidtagsget) | **GET** /projects/{projectId}/tags | Gets all instance tags of all machines in the project.
*ProjectApi* | [**ProjectsProjectIdTargetCloudCredentialsPost**](docs/ProjectApi.md#projectsprojectidtargetcloudcredentialspost) | **POST** /projects/{projectId}/targetCloudCredentials | Set target cloud credentials
*RecoveryPlansApi* | [**ProjectsProjectIdRecoveryPlansGet**](docs/RecoveryPlansApi.md#projectsprojectidrecoveryplansget) | **GET** /projects/{projectId}/recoveryPlans | Gets all recovery plans for the project.
*RecoveryPlansApi* | [**ProjectsProjectIdRecoveryPlansPost**](docs/RecoveryPlansApi.md#projectsprojectidrecoveryplanspost) | **POST** /projects/{projectId}/recoveryPlans | Creates a new recovery plan.
*RecoveryPlansApi* | [**ProjectsProjectIdRecoveryPlansRecoveryPlanIdDelete**](docs/RecoveryPlansApi.md#projectsprojectidrecoveryplansrecoveryplaniddelete) | **DELETE** /projects/{projectId}/recoveryPlans/{recoveryPlanId} | Deletes a recovery plan.
*RecoveryPlansApi* | [**ProjectsProjectIdRecoveryPlansRecoveryPlanIdGet**](docs/RecoveryPlansApi.md#projectsprojectidrecoveryplansrecoveryplanidget) | **GET** /projects/{projectId}/recoveryPlans/{recoveryPlanId} | Gets a recovery plan.
*RecoveryPlansApi* | [**ProjectsProjectIdRecoveryPlansRecoveryPlanIdPatch**](docs/RecoveryPlansApi.md#projectsprojectidrecoveryplansrecoveryplanidpatch) | **PATCH** /projects/{projectId}/recoveryPlans/{recoveryPlanId} | Updates a new recovery plan.
*RecoveryPlansApi* | [**ProjectsProjectIdRunRecoveryPlanPost**](docs/RecoveryPlansApi.md#projectsprojectidrunrecoveryplanpost) | **POST** /projects/{projectId}/runRecoveryPlan | Launch a recovery plan.
*ReplicationApi* | [**ProjectsProjectIdMachinesMachineIdBandwidthThrottlingGet**](docs/ReplicationApi.md#projectsprojectidmachinesmachineidbandwidththrottlingget) | **GET** /projects/{projectId}/machines/{machineId}/bandwidthThrottling | Get value of network bandwidth throttling setting for Machine
*ReplicationApi* | [**ProjectsProjectIdMachinesMachineIdBandwidthThrottlingPatch**](docs/ReplicationApi.md#projectsprojectidmachinesmachineidbandwidththrottlingpatch) | **PATCH** /projects/{projectId}/machines/{machineId}/bandwidthThrottling | Set value of network bandwidth throttling setting for Machine
*ReplicationApi* | [**ProjectsProjectIdMachinesMachineIdDelete**](docs/ReplicationApi.md#projectsprojectidmachinesmachineiddelete) | **DELETE** /projects/{projectId}/machines/{machineId} | Uninstall agent
*ReplicationApi* | [**ProjectsProjectIdMachinesMachineIdPointsintimeGet**](docs/ReplicationApi.md#projectsprojectidmachinesmachineidpointsintimeget) | **GET** /projects/{projectId}/machines/{machineId}/pointsintime | List Available Points-in-time
*ReplicationApi* | [**ProjectsProjectIdReplicationConfigurationsGet**](docs/ReplicationApi.md#projectsprojectidreplicationconfigurationsget) | **GET** /projects/{projectId}/replicationConfigurations | List Replication Configurations
*ReplicationApi* | [**ProjectsProjectIdReplicationConfigurationsPost**](docs/ReplicationApi.md#projectsprojectidreplicationconfigurationspost) | **POST** /projects/{projectId}/replicationConfigurations | Create Replication Configuration
*ReplicationApi* | [**ProjectsProjectIdReplicationConfigurationsReplicationConfigurationIdPatch**](docs/ReplicationApi.md#projectsprojectidreplicationconfigurationsreplicationconfigurationidpatch) | **PATCH** /projects/{projectId}/replicationConfigurations/{replicationConfigurationId} | Modify Replication Configuration
*UserApi* | [**ChangePasswordPost**](docs/UserApi.md#changepasswordpost) | **POST** /changePassword | Change Password
*UserApi* | [**MeGet**](docs/UserApi.md#meget) | **GET** /me | Me
*UserApi* | [**UsersUserIdDelete**](docs/UserApi.md#usersuseriddelete) | **DELETE** /users/{userId} | Delete a User
*UserApi* | [**UsersUserIdPatch**](docs/UserApi.md#usersuseridpatch) | **PATCH** /users/{userId} | Modify user settings

## Documentation for Models

- [Model.Account](docs/Account.md)
- [Model.AccountCeAdminProperties](docs/AccountCeAdminProperties.md)
- [Model.AccountLink](docs/AccountLink.md)
- [Model.AccountLinkList](docs/AccountLinkList.md)
- [Model.AccountRequest](docs/AccountRequest.md)
- [Model.AccountRequestList](docs/AccountRequestList.md)
- [Model.AccountsList](docs/AccountsList.md)
- [Model.AgentNextReplicationInitRequest](docs/AgentNextReplicationInitRequest.md)
- [Model.AllProjectFeatures](docs/AllProjectFeatures.md)
- [Model.AuditLog](docs/AuditLog.md)
- [Model.AuditLogChangedField](docs/AuditLogChangedField.md)
- [Model.AuditLogEntry](docs/AuditLogEntry.md)
- [Model.AuditLogEntryParticipatingMachines](docs/AuditLogEntryParticipatingMachines.md)
- [Model.BandwidthThrottling](docs/BandwidthThrottling.md)
- [Model.Blueprint](docs/Blueprint.md)
- [Model.BlueprintDisks](docs/BlueprintDisks.md)
- [Model.BlueprintList](docs/BlueprintList.md)
- [Model.Body](docs/Body.md)
- [Model.Body1](docs/Body1.md)
- [Model.Body10](docs/Body10.md)
- [Model.Body2](docs/Body2.md)
- [Model.Body3](docs/Body3.md)
- [Model.Body4](docs/Body4.md)
- [Model.Body5](docs/Body5.md)
- [Model.Body6](docs/Body6.md)
- [Model.Body7](docs/Body7.md)
- [Model.Body8](docs/Body8.md)
- [Model.Body9](docs/Body9.md)
- [Model.Cloud](docs/Cloud.md)
- [Model.CloudCredentials](docs/CloudCredentials.md)
- [Model.CloudCredentialsList](docs/CloudCredentialsList.md)
- [Model.CloudCredentialsRequest](docs/CloudCredentialsRequest.md)
- [Model.CloudsList](docs/CloudsList.md)
- [Model.ComputeLocation](docs/ComputeLocation.md)
- [Model.Configurations](docs/Configurations.md)
- [Model.ConfigurationsList](docs/ConfigurationsList.md)
- [Model.DiskConfig](docs/DiskConfig.md)
- [Model.DynamicConfiguration](docs/DynamicConfiguration.md)
- [Model.Error](docs/Error.md)
- [Model.ExtendedAccountInfo](docs/ExtendedAccountInfo.md)
- [Model.GcpMachinesFinanceData](docs/GcpMachinesFinanceData.md)
- [Model.IdentityProviderRedirectResponse](docs/IdentityProviderRedirectResponse.md)
- [Model.InitializationStep](docs/InitializationStep.md)
- [Model.InlineResponse200](docs/InlineResponse200.md)
- [Model.InlineResponse2001](docs/InlineResponse2001.md)
- [Model.InlineResponse2002](docs/InlineResponse2002.md)
- [Model.Job](docs/Job.md)
- [Model.JobLog](docs/JobLog.md)
- [Model.JobsList](docs/JobsList.md)
- [Model.KeyValueList](docs/KeyValueList.md)
- [Model.LaunchMachinesParameters](docs/LaunchMachinesParameters.md)
- [Model.LaunchMachinesParametersDebugScripts](docs/LaunchMachinesParametersDebugScripts.md)
- [Model.License](docs/License.md)
- [Model.LicenseCeAdminProperties](docs/LicenseCeAdminProperties.md)
- [Model.LicenseFeatures](docs/LicenseFeatures.md)
- [Model.LicenseList](docs/LicenseList.md)
- [Model.ListUsersResult](docs/ListUsersResult.md)
- [Model.ListUsersResults](docs/ListUsersResults.md)
- [Model.LogicalLocation](docs/LogicalLocation.md)
- [Model.Machine](docs/Machine.md)
- [Model.MachineAndPathAndPointInTime](docs/MachineAndPathAndPointInTime.md)
- [Model.MachineAndPointInTime](docs/MachineAndPointInTime.md)
- [Model.MachineLicense](docs/MachineLicense.md)
- [Model.MachineLifeCycle](docs/MachineLifeCycle.md)
- [Model.MachineReplicationConfiguration](docs/MachineReplicationConfiguration.md)
- [Model.MachineReplicationInfo](docs/MachineReplicationInfo.md)
- [Model.MachineReplicationInfoInitiationStates](docs/MachineReplicationInfoInitiationStates.md)
- [Model.MachineReplicationInfoInitiationStatesItems](docs/MachineReplicationInfoInitiationStatesItems.md)
- [Model.MachineSnapshotCredits](docs/MachineSnapshotCredits.md)
- [Model.MachineSourceProperties](docs/MachineSourceProperties.md)
- [Model.MachineSourcePropertiesCpu](docs/MachineSourcePropertiesCpu.md)
- [Model.MachineSourcePropertiesDisks](docs/MachineSourcePropertiesDisks.md)
- [Model.MachineSourcePropertiesInstalledApplications](docs/MachineSourcePropertiesInstalledApplications.md)
- [Model.MachineSourcePropertiesInstalledApplicationsItems](docs/MachineSourcePropertiesInstalledApplicationsItems.md)
- [Model.MachineSourcePropertiesRunningServices](docs/MachineSourcePropertiesRunningServices.md)
- [Model.MachineSourcePropertiesRunningServicesItems](docs/MachineSourcePropertiesRunningServicesItems.md)
- [Model.MachineThrottleTimeSeconds](docs/MachineThrottleTimeSeconds.md)
- [Model.MachinesList](docs/MachinesList.md)
- [Model.MachinesListInvalidIDsAndJob](docs/MachinesListInvalidIDsAndJob.md)
- [Model.NetworkInterface](docs/NetworkInterface.md)
- [Model.PointInTime](docs/PointInTime.md)
- [Model.PointInTimeList](docs/PointInTimeList.md)
- [Model.PopulateJobNames](docs/PopulateJobNames.md)
- [Model.PopulateJobParams](docs/PopulateJobParams.md)
- [Model.Project](docs/Project.md)
- [Model.ProjectCeAdminProperties](docs/ProjectCeAdminProperties.md)
- [Model.ProjectFeatures](docs/ProjectFeatures.md)
- [Model.ProjectStorage](docs/ProjectStorage.md)
- [Model.ProjectStorageWorkingStorage](docs/ProjectStorageWorkingStorage.md)
- [Model.ProjectsAndUsers](docs/ProjectsAndUsers.md)
- [Model.ProjectsAndUsersItems](docs/ProjectsAndUsersItems.md)
- [Model.ProjectsList](docs/ProjectsList.md)
- [Model.RecoveryPlan](docs/RecoveryPlan.md)
- [Model.RecoveryPlanList](docs/RecoveryPlanList.md)
- [Model.RecoveryPlanStep](docs/RecoveryPlanStep.md)
- [Model.RecoveryPlanSteps](docs/RecoveryPlanSteps.md)
- [Model.Region](docs/Region.md)
- [Model.RegionsList](docs/RegionsList.md)
- [Model.Replica](docs/Replica.md)
- [Model.ReplicationConfiguration](docs/ReplicationConfiguration.md)
- [Model.ReplicationConfigurationList](docs/ReplicationConfigurationList.md)
- [Model.ReplicationConfigurationReplicationTags](docs/ReplicationConfigurationReplicationTags.md)
- [Model.SamlSettings](docs/SamlSettings.md)
- [Model.SecurityGroup](docs/SecurityGroup.md)
- [Model.StorageLocation](docs/StorageLocation.md)
- [Model.Subnet](docs/Subnet.md)
- [Model.Time](docs/Time.md)
- [Model.UpdateableScripts](docs/UpdateableScripts.md)
- [Model.UpdateableScriptsResult](docs/UpdateableScriptsResult.md)
- [Model.UpdateableScriptsResultOnPremiseVolumes](docs/UpdateableScriptsResultOnPremiseVolumes.md)
- [Model.UpgradeCounterDelay](docs/UpgradeCounterDelay.md)
- [Model.Usage](docs/Usage.md)
- [Model.UsageList](docs/UsageList.md)
- [Model.User](docs/User.md)
- [Model.UserReport](docs/UserReport.md)
- [Model.UserReportGcpMachinesFinanceData](docs/UserReportGcpMachinesFinanceData.md)
- [Model.UserReports](docs/UserReports.md)
- [Model.UserSettings](docs/UserSettings.md)
- [Model.UserSettingsSendNotifications](docs/UserSettingsSendNotifications.md)
- [Model.UsersAndRoles](docs/UsersAndRoles.md)
- [Model.UsersAndRolesItems](docs/UsersAndRolesItems.md)
- [Model.UsersList](docs/UsersList.md)