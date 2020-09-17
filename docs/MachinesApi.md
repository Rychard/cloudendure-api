# CloudEndure.Api.MachinesApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProjectsProjectIdMachinesDelete**](MachinesApi.md#projectsprojectidmachinesdelete) | **DELETE** /projects/{projectId}/machines | Uninstall multiple agents
[**ProjectsProjectIdMachinesGet**](MachinesApi.md#projectsprojectidmachinesget) | **GET** /projects/{projectId}/machines | List Machines
[**ProjectsProjectIdMachinesMachineIdDelete**](MachinesApi.md#projectsprojectidmachinesmachineiddelete) | **DELETE** /projects/{projectId}/machines/{machineId} | Uninstall agent
[**ProjectsProjectIdMachinesMachineIdGet**](MachinesApi.md#projectsprojectidmachinesmachineidget) | **GET** /projects/{projectId}/machines/{machineId} | Get a specific machine.
[**ProjectsProjectIdMachinesMachineIdPatch**](MachinesApi.md#projectsprojectidmachinesmachineidpatch) | **PATCH** /projects/{projectId}/machines/{machineId} | Update a machine. Accepts only Launch time updates.
[**ProjectsProjectIdMachinesPatch**](MachinesApi.md#projectsprojectidmachinespatch) | **PATCH** /projects/{projectId}/machines | Batch-update multiple machines
[**ProjectsProjectIdReplicasReplicaIdGet**](MachinesApi.md#projectsprojectidreplicasreplicaidget) | **GET** /projects/{projectId}/replicas/{replicaId} | Get Target Machine

<a name="projectsprojectidmachinesdelete"></a>
# **ProjectsProjectIdMachinesDelete**
> void ProjectsProjectIdMachinesDelete (Body8 body, string projectId)

Uninstall multiple agents

Stops replication and removes the cloudendure agent from the specified machines. All cloud artifacts associated with those machines with the exception of launched target machines are deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdMachinesDeleteExample
    {
        public void main()
        {
            var apiInstance = new MachinesApi();
            var body = new Body8(); // Body8 | The list of machine IDs to remove from the CloudEndure service.
            var projectId = projectId_example;  // string | 

            try
            {
                // Uninstall multiple agents
                apiInstance.ProjectsProjectIdMachinesDelete(body, projectId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MachinesApi.ProjectsProjectIdMachinesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body8**](Body8.md)| The list of machine IDs to remove from the CloudEndure service. | 
 **projectId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidmachinesget"></a>
# **ProjectsProjectIdMachinesGet**
> MachinesList ProjectsProjectIdMachinesGet (string projectId, int? offset = null, int? limit = null, bool? all = null, string types = null)

List Machines

Returns the list of all source machines in the Project (i.e. machines that have an Agent installed).

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdMachinesGetExample
    {
        public void main()
        {
            var apiInstance = new MachinesApi();
            var projectId = projectId_example;  // string | 
            var offset = 56;  // int? | With which item to start (0 based). (optional)  (default to 0)
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)
            var all = true;  // bool? | When set to false, returns only currently replicating machines. When set to true, returns all machines in the project regardless of replications status. machines are consuming/ have consumed licenses.  Note that some license types are transferable and therefore once you remove the and set to true false, returns only currently replicating machines. When set to true, returns all machines in the project regardless of replications status.  (optional)  (default to false)
            var types = types_example;  // string | Use this url query param to control which machines are returned when doing GET.  If you do not include the \\\"types\\\" query param, you will only get source machines  (optional) 

            try
            {
                // List Machines
                MachinesList result = apiInstance.ProjectsProjectIdMachinesGet(projectId, offset, limit, all, types);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MachinesApi.ProjectsProjectIdMachinesGet: " + e.Message );
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
 **all** | **bool?**| When set to false, returns only currently replicating machines. When set to true, returns all machines in the project regardless of replications status. machines are consuming/ have consumed licenses.  Note that some license types are transferable and therefore once you remove the and set to true false, returns only currently replicating machines. When set to true, returns all machines in the project regardless of replications status.  | [optional] [default to false]
 **types** | **string**| Use this url query param to control which machines are returned when doing GET.  If you do not include the \\\&quot;types\\\&quot; query param, you will only get source machines  | [optional] 

### Return type

[**MachinesList**](MachinesList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidmachinesmachineiddelete"></a>
# **ProjectsProjectIdMachinesMachineIdDelete**
> void ProjectsProjectIdMachinesMachineIdDelete (string projectId, string machineId)

Uninstall agent

Stops replication and removes the cloudendure agent from this machine. All cloud artifacts associated with those machines with the exception of launched target machine are deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdMachinesMachineIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new MachinesApi();
            var projectId = projectId_example;  // string | 
            var machineId = machineId_example;  // string | 

            try
            {
                // Uninstall agent
                apiInstance.ProjectsProjectIdMachinesMachineIdDelete(projectId, machineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MachinesApi.ProjectsProjectIdMachinesMachineIdDelete: " + e.Message );
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
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidmachinesmachineidget"></a>
# **ProjectsProjectIdMachinesMachineIdGet**
> Machine ProjectsProjectIdMachinesMachineIdGet (string projectId, string machineId)

Get a specific machine.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdMachinesMachineIdGetExample
    {
        public void main()
        {
            var apiInstance = new MachinesApi();
            var projectId = projectId_example;  // string | 
            var machineId = machineId_example;  // string | 

            try
            {
                // Get a specific machine.
                Machine result = apiInstance.ProjectsProjectIdMachinesMachineIdGet(projectId, machineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MachinesApi.ProjectsProjectIdMachinesMachineIdGet: " + e.Message );
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

[**Machine**](Machine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidmachinesmachineidpatch"></a>
# **ProjectsProjectIdMachinesMachineIdPatch**
> Machine ProjectsProjectIdMachinesMachineIdPatch (Machine body, string projectId, string machineId)

Update a machine. Accepts only Launch time updates.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdMachinesMachineIdPatchExample
    {
        public void main()
        {
            var apiInstance = new MachinesApi();
            var body = new Machine(); // Machine | 
            var projectId = projectId_example;  // string | 
            var machineId = machineId_example;  // string | 

            try
            {
                // Update a machine. Accepts only Launch time updates.
                Machine result = apiInstance.ProjectsProjectIdMachinesMachineIdPatch(body, projectId, machineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MachinesApi.ProjectsProjectIdMachinesMachineIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Machine**](Machine.md)|  | 
 **projectId** | **string**|  | 
 **machineId** | **string**|  | 

### Return type

[**Machine**](Machine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidmachinespatch"></a>
# **ProjectsProjectIdMachinesPatch**
> MachinesList ProjectsProjectIdMachinesPatch (MachinesList body, string projectId)

Batch-update multiple machines

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdMachinesPatchExample
    {
        public void main()
        {
            var apiInstance = new MachinesApi();
            var body = new MachinesList(); // MachinesList | 
            var projectId = projectId_example;  // string | 

            try
            {
                // Batch-update multiple machines
                MachinesList result = apiInstance.ProjectsProjectIdMachinesPatch(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MachinesApi.ProjectsProjectIdMachinesPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MachinesList**](MachinesList.md)|  | 
 **projectId** | **string**|  | 

### Return type

[**MachinesList**](MachinesList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidreplicasreplicaidget"></a>
# **ProjectsProjectIdReplicasReplicaIdGet**
> Replica ProjectsProjectIdReplicasReplicaIdGet (string projectId, string replicaId)

Get Target Machine

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdReplicasReplicaIdGetExample
    {
        public void main()
        {
            var apiInstance = new MachinesApi();
            var projectId = projectId_example;  // string | 
            var replicaId = replicaId_example;  // string | 

            try
            {
                // Get Target Machine
                Replica result = apiInstance.ProjectsProjectIdReplicasReplicaIdGet(projectId, replicaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MachinesApi.ProjectsProjectIdReplicasReplicaIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **replicaId** | **string**|  | 

### Return type

[**Replica**](Replica.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
