# CloudEndure.Api.RecoveryPlansApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProjectsProjectIdRecoveryPlansGet**](RecoveryPlansApi.md#projectsprojectidrecoveryplansget) | **GET** /projects/{projectId}/recoveryPlans | Gets all recovery plans for the project.
[**ProjectsProjectIdRecoveryPlansPost**](RecoveryPlansApi.md#projectsprojectidrecoveryplanspost) | **POST** /projects/{projectId}/recoveryPlans | Creates a new recovery plan.
[**ProjectsProjectIdRecoveryPlansRecoveryPlanIdDelete**](RecoveryPlansApi.md#projectsprojectidrecoveryplansrecoveryplaniddelete) | **DELETE** /projects/{projectId}/recoveryPlans/{recoveryPlanId} | Deletes a recovery plan.
[**ProjectsProjectIdRecoveryPlansRecoveryPlanIdGet**](RecoveryPlansApi.md#projectsprojectidrecoveryplansrecoveryplanidget) | **GET** /projects/{projectId}/recoveryPlans/{recoveryPlanId} | Gets a recovery plan.
[**ProjectsProjectIdRecoveryPlansRecoveryPlanIdPatch**](RecoveryPlansApi.md#projectsprojectidrecoveryplansrecoveryplanidpatch) | **PATCH** /projects/{projectId}/recoveryPlans/{recoveryPlanId} | Updates a new recovery plan.
[**ProjectsProjectIdRunRecoveryPlanPost**](RecoveryPlansApi.md#projectsprojectidrunrecoveryplanpost) | **POST** /projects/{projectId}/runRecoveryPlan | Launch a recovery plan.

<a name="projectsprojectidrecoveryplansget"></a>
# **ProjectsProjectIdRecoveryPlansGet**
> RecoveryPlanList ProjectsProjectIdRecoveryPlansGet (string projectId)

Gets all recovery plans for the project.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdRecoveryPlansGetExample
    {
        public void main()
        {
            var apiInstance = new RecoveryPlansApi();
            var projectId = projectId_example;  // string | 

            try
            {
                // Gets all recovery plans for the project.
                RecoveryPlanList result = apiInstance.ProjectsProjectIdRecoveryPlansGet(projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryPlansApi.ProjectsProjectIdRecoveryPlansGet: " + e.Message );
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

[**RecoveryPlanList**](RecoveryPlanList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidrecoveryplanspost"></a>
# **ProjectsProjectIdRecoveryPlansPost**
> RecoveryPlan ProjectsProjectIdRecoveryPlansPost (RecoveryPlan body, string projectId)

Creates a new recovery plan.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdRecoveryPlansPostExample
    {
        public void main()
        {
            var apiInstance = new RecoveryPlansApi();
            var body = new RecoveryPlan(); // RecoveryPlan | Recovery Plan to create
            var projectId = projectId_example;  // string | 

            try
            {
                // Creates a new recovery plan.
                RecoveryPlan result = apiInstance.ProjectsProjectIdRecoveryPlansPost(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryPlansApi.ProjectsProjectIdRecoveryPlansPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecoveryPlan**](RecoveryPlan.md)| Recovery Plan to create | 
 **projectId** | **string**|  | 

### Return type

[**RecoveryPlan**](RecoveryPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidrecoveryplansrecoveryplaniddelete"></a>
# **ProjectsProjectIdRecoveryPlansRecoveryPlanIdDelete**
> void ProjectsProjectIdRecoveryPlansRecoveryPlanIdDelete (string projectId, string recoveryPlanId)

Deletes a recovery plan.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdRecoveryPlansRecoveryPlanIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new RecoveryPlansApi();
            var projectId = projectId_example;  // string | 
            var recoveryPlanId = recoveryPlanId_example;  // string | 

            try
            {
                // Deletes a recovery plan.
                apiInstance.ProjectsProjectIdRecoveryPlansRecoveryPlanIdDelete(projectId, recoveryPlanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryPlansApi.ProjectsProjectIdRecoveryPlansRecoveryPlanIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **recoveryPlanId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidrecoveryplansrecoveryplanidget"></a>
# **ProjectsProjectIdRecoveryPlansRecoveryPlanIdGet**
> RecoveryPlan ProjectsProjectIdRecoveryPlansRecoveryPlanIdGet (string projectId, string recoveryPlanId)

Gets a recovery plan.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdRecoveryPlansRecoveryPlanIdGetExample
    {
        public void main()
        {
            var apiInstance = new RecoveryPlansApi();
            var projectId = projectId_example;  // string | 
            var recoveryPlanId = recoveryPlanId_example;  // string | 

            try
            {
                // Gets a recovery plan.
                RecoveryPlan result = apiInstance.ProjectsProjectIdRecoveryPlansRecoveryPlanIdGet(projectId, recoveryPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryPlansApi.ProjectsProjectIdRecoveryPlansRecoveryPlanIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **recoveryPlanId** | **string**|  | 

### Return type

[**RecoveryPlan**](RecoveryPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidrecoveryplansrecoveryplanidpatch"></a>
# **ProjectsProjectIdRecoveryPlansRecoveryPlanIdPatch**
> RecoveryPlan ProjectsProjectIdRecoveryPlansRecoveryPlanIdPatch (RecoveryPlan body, string projectId, string recoveryPlanId)

Updates a new recovery plan.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdRecoveryPlansRecoveryPlanIdPatchExample
    {
        public void main()
        {
            var apiInstance = new RecoveryPlansApi();
            var body = new RecoveryPlan(); // RecoveryPlan | Recovery Plan to create
            var projectId = projectId_example;  // string | 
            var recoveryPlanId = recoveryPlanId_example;  // string | 

            try
            {
                // Updates a new recovery plan.
                RecoveryPlan result = apiInstance.ProjectsProjectIdRecoveryPlansRecoveryPlanIdPatch(body, projectId, recoveryPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryPlansApi.ProjectsProjectIdRecoveryPlansRecoveryPlanIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecoveryPlan**](RecoveryPlan.md)| Recovery Plan to create | 
 **projectId** | **string**|  | 
 **recoveryPlanId** | **string**|  | 

### Return type

[**RecoveryPlan**](RecoveryPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidrunrecoveryplanpost"></a>
# **ProjectsProjectIdRunRecoveryPlanPost**
> Job ProjectsProjectIdRunRecoveryPlanPost (Body10 body, string projectId)

Launch a recovery plan.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdRunRecoveryPlanPostExample
    {
        public void main()
        {
            var apiInstance = new RecoveryPlansApi();
            var body = new Body10(); // Body10 | Recovery Plan to create
            var projectId = projectId_example;  // string | 

            try
            {
                // Launch a recovery plan.
                Job result = apiInstance.ProjectsProjectIdRunRecoveryPlanPost(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecoveryPlansApi.ProjectsProjectIdRunRecoveryPlanPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body10**](Body10.md)| Recovery Plan to create | 
 **projectId** | **string**|  | 

### Return type

[**Job**](Job.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
