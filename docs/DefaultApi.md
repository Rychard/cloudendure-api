# CloudEndure.Api.DefaultApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsAccountIdAccessGet**](DefaultApi.md#accountsaccountidaccessget) | **GET** /accounts/{accountId}/access | get a temporary token by email
[**ExtendedAccountInfoGet**](DefaultApi.md#extendedaccountinfoget) | **GET** /extendedAccountInfo | Returns the extended current account information.
[**ProjectsAssignUsersPost**](DefaultApi.md#projectsassignuserspost) | **POST** /projects/assignUsers | Assign User
[**ProjectsProjectIdAuditLogGet**](DefaultApi.md#projectsprojectidauditlogget) | **GET** /projects/{projectId}/auditLog | Get audit log
[**ProjectsProjectIdMachinesMachineIdForceRescanPost**](DefaultApi.md#projectsprojectidmachinesmachineidforcerescanpost) | **POST** /projects/{projectId}/machines/{machineId}/forceRescan | Force rescan of machine volumes.
[**ProjectsProjectIdStorageGet**](DefaultApi.md#projectsprojectidstorageget) | **GET** /projects/{projectId}/storage | project&#x27;s storage
[**ProjectsRemoveUsersPost**](DefaultApi.md#projectsremoveuserspost) | **POST** /projects/removeUsers | Remove User
[**ReplaceApiTokenPost**](DefaultApi.md#replaceapitokenpost) | **POST** /replaceApiToken | Replaces API token
[**SetPasswordPost**](DefaultApi.md#setpasswordpost) | **POST** /setPassword | Set password for invited user
[**UsersAssignRolesPost**](DefaultApi.md#usersassignrolespost) | **POST** /users/assignRoles | Add roles to users
[**UsersPost**](DefaultApi.md#userspost) | **POST** /users | Create a new User
[**UsersRevokeRolesPost**](DefaultApi.md#usersrevokerolespost) | **POST** /users/revokeRoles | Revoke roles from users

<a name="accountsaccountidaccessget"></a>
# **AccountsAccountIdAccessGet**
> InlineResponse2002 AccountsAccountIdAccessGet (string accountId, string username)

get a temporary token by email

get a temporary token by email. Available for account owner when SSO is used

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class AccountsAccountIdAccessGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var accountId = accountId_example;  // string | 
            var username = username_example;  // string | 

            try
            {
                // get a temporary token by email
                InlineResponse2002 result = apiInstance.AccountsAccountIdAccessGet(accountId, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AccountsAccountIdAccessGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **username** | **string**|  | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="extendedaccountinfoget"></a>
# **ExtendedAccountInfoGet**
> ExtendedAccountInfo ExtendedAccountInfoGet ()

Returns the extended current account information.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ExtendedAccountInfoGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                // Returns the extended current account information.
                ExtendedAccountInfo result = apiInstance.ExtendedAccountInfoGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ExtendedAccountInfoGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ExtendedAccountInfo**](ExtendedAccountInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsassignuserspost"></a>
# **ProjectsAssignUsersPost**
> void ProjectsAssignUsersPost (ProjectsAndUsers body)

Assign User

Assign User to Project

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsAssignUsersPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ProjectsAndUsers(); // ProjectsAndUsers | 

            try
            {
                // Assign User
                apiInstance.ProjectsAssignUsersPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProjectsAssignUsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectsAndUsers**](ProjectsAndUsers.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidauditlogget"></a>
# **ProjectsProjectIdAuditLogGet**
> AuditLog ProjectsProjectIdAuditLogGet (string projectId, int? limit = null, DateTime? fromDateTime = null, DateTime? toDateTime = null, string format = null)

Get audit log

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdAuditLogGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var projectId = projectId_example;  // string | 
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)
            var fromDateTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Used to limit the response to a specific date range. Must be used in conjunction with toDateTime param. (optional) 
            var toDateTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Used to limit the response to a specific date range. Must be used in conjunction with fromDateTime param. (optional) 
            var format = format_example;  // string |  (optional)  (default to json)

            try
            {
                // Get audit log
                AuditLog result = apiInstance.ProjectsProjectIdAuditLogGet(projectId, limit, fromDateTime, toDateTime, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProjectsProjectIdAuditLogGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **limit** | **int?**| A number specifying how many entries to return. | [optional] [default to 1500]
 **fromDateTime** | **DateTime?**| Used to limit the response to a specific date range. Must be used in conjunction with toDateTime param. | [optional] 
 **toDateTime** | **DateTime?**| Used to limit the response to a specific date range. Must be used in conjunction with fromDateTime param. | [optional] 
 **format** | **string**|  | [optional] [default to json]

### Return type

[**AuditLog**](AuditLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidmachinesmachineidforcerescanpost"></a>
# **ProjectsProjectIdMachinesMachineIdForceRescanPost**
> void ProjectsProjectIdMachinesMachineIdForceRescanPost (string projectId, string machineId)

Force rescan of machine volumes.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdMachinesMachineIdForceRescanPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var projectId = projectId_example;  // string | 
            var machineId = machineId_example;  // string | 

            try
            {
                // Force rescan of machine volumes.
                apiInstance.ProjectsProjectIdMachinesMachineIdForceRescanPost(projectId, machineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProjectsProjectIdMachinesMachineIdForceRescanPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **machineId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidstorageget"></a>
# **ProjectsProjectIdStorageGet**
> ProjectStorage ProjectsProjectIdStorageGet (string projectId)

project's storage

get project's storage usage (vCenter only)

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdStorageGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var projectId = projectId_example;  // string | 

            try
            {
                // project's storage
                ProjectStorage result = apiInstance.ProjectsProjectIdStorageGet(projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProjectsProjectIdStorageGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 

### Return type

[**ProjectStorage**](ProjectStorage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsremoveuserspost"></a>
# **ProjectsRemoveUsersPost**
> void ProjectsRemoveUsersPost (ProjectsAndUsers body)

Remove User

Remove User from Project

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsRemoveUsersPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ProjectsAndUsers(); // ProjectsAndUsers | 

            try
            {
                // Remove User
                apiInstance.ProjectsRemoveUsersPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ProjectsRemoveUsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectsAndUsers**](ProjectsAndUsers.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceapitokenpost"></a>
# **ReplaceApiTokenPost**
> InlineResponse2001 ReplaceApiTokenPost ()

Replaces API token

Replaces API token

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ReplaceApiTokenPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                // Replaces API token
                InlineResponse2001 result = apiInstance.ReplaceApiTokenPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ReplaceApiTokenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setpasswordpost"></a>
# **SetPasswordPost**
> void SetPasswordPost (Body2 body)

Set password for invited user

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class SetPasswordPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new Body2(); // Body2 | set password token and new password

            try
            {
                // Set password for invited user
                apiInstance.SetPasswordPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SetPasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body2**](Body2.md)| set password token and new password | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersassignrolespost"></a>
# **UsersAssignRolesPost**
> UsersList UsersAssignRolesPost (UsersAndRoles body)

Add roles to users

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class UsersAssignRolesPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new UsersAndRoles(); // UsersAndRoles | 

            try
            {
                // Add roles to users
                UsersList result = apiInstance.UsersAssignRolesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UsersAssignRolesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersAndRoles**](UsersAndRoles.md)|  | 

### Return type

[**UsersList**](UsersList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="userspost"></a>
# **UsersPost**
> User UsersPost (Body6 body)

Create a new User

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class UsersPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new Body6(); // Body6 | 

            try
            {
                // Create a new User
                User result = apiInstance.UsersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body6**](Body6.md)|  | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersrevokerolespost"></a>
# **UsersRevokeRolesPost**
> UsersList UsersRevokeRolesPost (UsersAndRoles body)

Revoke roles from users

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class UsersRevokeRolesPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new UsersAndRoles(); // UsersAndRoles | 

            try
            {
                // Revoke roles from users
                UsersList result = apiInstance.UsersRevokeRolesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UsersRevokeRolesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersAndRoles**](UsersAndRoles.md)|  | 

### Return type

[**UsersList**](UsersList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
