# CloudEndure.Api.BlueprintApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProjectsProjectIdBlueprintsBlueprintIdGet**](BlueprintApi.md#projectsprojectidblueprintsblueprintidget) | **GET** /projects/{projectId}/blueprints/{blueprintId} | Get Blueprint
[**ProjectsProjectIdBlueprintsBlueprintIdPatch**](BlueprintApi.md#projectsprojectidblueprintsblueprintidpatch) | **PATCH** /projects/{projectId}/blueprints/{blueprintId} | Configure Blueprint
[**ProjectsProjectIdBlueprintsGet**](BlueprintApi.md#projectsprojectidblueprintsget) | **GET** /projects/{projectId}/blueprints | List Blueprints
[**ProjectsProjectIdBlueprintsPost**](BlueprintApi.md#projectsprojectidblueprintspost) | **POST** /projects/{projectId}/blueprints | Create Blueprint

<a name="projectsprojectidblueprintsblueprintidget"></a>
# **ProjectsProjectIdBlueprintsBlueprintIdGet**
> Blueprint ProjectsProjectIdBlueprintsBlueprintIdGet (string projectId, string blueprintId)

Get Blueprint

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdBlueprintsBlueprintIdGetExample
    {
        public void main()
        {
            var apiInstance = new BlueprintApi();
            var projectId = projectId_example;  // string | 
            var blueprintId = blueprintId_example;  // string | 

            try
            {
                // Get Blueprint
                Blueprint result = apiInstance.ProjectsProjectIdBlueprintsBlueprintIdGet(projectId, blueprintId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlueprintApi.ProjectsProjectIdBlueprintsBlueprintIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **blueprintId** | **string**|  | 

### Return type

[**Blueprint**](Blueprint.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidblueprintsblueprintidpatch"></a>
# **ProjectsProjectIdBlueprintsBlueprintIdPatch**
> Blueprint ProjectsProjectIdBlueprintsBlueprintIdPatch (Blueprint body, string projectId, string blueprintId)

Configure Blueprint

Configure target machine characteristics: machine and disk types, network configuration, etc. Returns the modified object.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdBlueprintsBlueprintIdPatchExample
    {
        public void main()
        {
            var apiInstance = new BlueprintApi();
            var body = new Blueprint(); // Blueprint | 
            var projectId = projectId_example;  // string | 
            var blueprintId = blueprintId_example;  // string | 

            try
            {
                // Configure Blueprint
                Blueprint result = apiInstance.ProjectsProjectIdBlueprintsBlueprintIdPatch(body, projectId, blueprintId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlueprintApi.ProjectsProjectIdBlueprintsBlueprintIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Blueprint**](Blueprint.md)|  | 
 **projectId** | **string**|  | 
 **blueprintId** | **string**|  | 

### Return type

[**Blueprint**](Blueprint.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidblueprintsget"></a>
# **ProjectsProjectIdBlueprintsGet**
> BlueprintList ProjectsProjectIdBlueprintsGet (string projectId, int? offset = null, int? limit = null)

List Blueprints

Returns the list of available blueprints in the project.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdBlueprintsGetExample
    {
        public void main()
        {
            var apiInstance = new BlueprintApi();
            var projectId = projectId_example;  // string | 
            var offset = 56;  // int? | With which item to start (0 based). (optional)  (default to 0)
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)

            try
            {
                // List Blueprints
                BlueprintList result = apiInstance.ProjectsProjectIdBlueprintsGet(projectId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlueprintApi.ProjectsProjectIdBlueprintsGet: " + e.Message );
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

[**BlueprintList**](BlueprintList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidblueprintspost"></a>
# **ProjectsProjectIdBlueprintsPost**
> Blueprint ProjectsProjectIdBlueprintsPost (Blueprint body, string projectId)

Create Blueprint

Define the target machine characteristics: machine and disk types, network configuration, etc. There can be only one blueprint per machine per region. Returns the newly created object.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdBlueprintsPostExample
    {
        public void main()
        {
            var apiInstance = new BlueprintApi();
            var body = new Blueprint(); // Blueprint | 
            var projectId = projectId_example;  // string | 

            try
            {
                // Create Blueprint
                Blueprint result = apiInstance.ProjectsProjectIdBlueprintsPost(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlueprintApi.ProjectsProjectIdBlueprintsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Blueprint**](Blueprint.md)|  | 
 **projectId** | **string**|  | 

### Return type

[**Blueprint**](Blueprint.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
