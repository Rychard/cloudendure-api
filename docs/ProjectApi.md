# CloudEndure.Api.ProjectApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProjectsGet**](ProjectApi.md#projectsget) | **GET** /projects | List Projects
[**ProjectsPost**](ProjectApi.md#projectspost) | **POST** /projects | Create Project
[**ProjectsProjectIdDelete**](ProjectApi.md#projectsprojectiddelete) | **DELETE** /projects/{projectId} | Delete Project and all sub-resources including cloud assets other than launched target machines
[**ProjectsProjectIdGet**](ProjectApi.md#projectsprojectidget) | **GET** /projects/{projectId} | Get Project
[**ProjectsProjectIdPatch**](ProjectApi.md#projectsprojectidpatch) | **PATCH** /projects/{projectId} | Update Project (including partial update)
[**ProjectsProjectIdTagsGet**](ProjectApi.md#projectsprojectidtagsget) | **GET** /projects/{projectId}/tags | Gets all instance tags of all machines in the project.
[**ProjectsProjectIdTargetCloudCredentialsPost**](ProjectApi.md#projectsprojectidtargetcloudcredentialspost) | **POST** /projects/{projectId}/targetCloudCredentials | Set target cloud credentials

<a name="projectsget"></a>
# **ProjectsGet**
> ProjectsList ProjectsGet (int? offset = null, int? limit = null)

List Projects

Returns the list of projects defined in this account.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsGetExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var offset = 56;  // int? | With which item to start (0 based). (optional)  (default to 0)
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)

            try
            {
                // List Projects
                ProjectsList result = apiInstance.ProjectsGet(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ProjectsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| With which item to start (0 based). | [optional] [default to 0]
 **limit** | **int?**| A number specifying how many entries to return. | [optional] [default to 1500]

### Return type

[**ProjectsList**](ProjectsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectspost"></a>
# **ProjectsPost**
> Project ProjectsPost (Project body)

Create Project

Create project

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsPostExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var body = new Project(); // Project | 

            try
            {
                // Create Project
                Project result = apiInstance.ProjectsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ProjectsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Project**](Project.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectiddelete"></a>
# **ProjectsProjectIdDelete**
> void ProjectsProjectIdDelete (string projectId)

Delete Project and all sub-resources including cloud assets other than launched target machines

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectId = projectId_example;  // string | 

            try
            {
                // Delete Project and all sub-resources including cloud assets other than launched target machines
                apiInstance.ProjectsProjectIdDelete(projectId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ProjectsProjectIdDelete: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidget"></a>
# **ProjectsProjectIdGet**
> Project ProjectsProjectIdGet (string projectId)

Get Project

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdGetExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectId = projectId_example;  // string | 

            try
            {
                // Get Project
                Project result = apiInstance.ProjectsProjectIdGet(projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ProjectsProjectIdGet: " + e.Message );
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

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidpatch"></a>
# **ProjectsProjectIdPatch**
> Project ProjectsProjectIdPatch (Project body, string projectId)

Update Project (including partial update)

Set project properties including Data Replication source location and replicationConfiguration to use.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdPatchExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var body = new Project(); // Project | 
            var projectId = projectId_example;  // string | 

            try
            {
                // Update Project (including partial update)
                Project result = apiInstance.ProjectsProjectIdPatch(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ProjectsProjectIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Project**](Project.md)|  | 
 **projectId** | **string**|  | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidtagsget"></a>
# **ProjectsProjectIdTagsGet**
> InlineResponse200 ProjectsProjectIdTagsGet (string projectId, int? offset = null, int? limit = null)

Gets all instance tags of all machines in the project.

Returns all instance tags of all machines in the project.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdTagsGetExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectId = projectId_example;  // string | 
            var offset = 56;  // int? | With which item to start (0 based). (optional)  (default to 0)
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)

            try
            {
                // Gets all instance tags of all machines in the project.
                InlineResponse200 result = apiInstance.ProjectsProjectIdTagsGet(projectId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ProjectsProjectIdTagsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **offset** | **int?**| With which item to start (0 based). | [optional] [default to 0]
 **limit** | **int?**| A number specifying how many entries to return. | [optional] [default to 1500]

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidtargetcloudcredentialspost"></a>
# **ProjectsProjectIdTargetCloudCredentialsPost**
> Project ProjectsProjectIdTargetCloudCredentialsPost (CloudCredentialsRequest body, string projectId)

Set target cloud credentials

Used to set different account for staging and target. Changes target credentials for account. null values can be used to remove the credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdTargetCloudCredentialsPostExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var body = new CloudCredentialsRequest(); // CloudCredentialsRequest | 
            var projectId = projectId_example;  // string | 

            try
            {
                // Set target cloud credentials
                Project result = apiInstance.ProjectsProjectIdTargetCloudCredentialsPost(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ProjectsProjectIdTargetCloudCredentialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CloudCredentialsRequest**](CloudCredentialsRequest.md)|  | 
 **projectId** | **string**|  | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
