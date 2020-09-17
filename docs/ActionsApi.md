# CloudEndure.Api.ActionsApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProjectsProjectIdJobsGet**](ActionsApi.md#projectsprojectidjobsget) | **GET** /projects/{projectId}/jobs | List Jobs
[**ProjectsProjectIdJobsJobIdGet**](ActionsApi.md#projectsprojectidjobsjobidget) | **GET** /projects/{projectId}/jobs/{jobId} | Get Job
[**ProjectsProjectIdLaunchMachinesPost**](ActionsApi.md#projectsprojectidlaunchmachinespost) | **POST** /projects/{projectId}/launchMachines | Launch target machines
[**ProjectsProjectIdLaunchRestoreServersPost**](ActionsApi.md#projectsprojectidlaunchrestoreserverspost) | **POST** /projects/{projectId}/launchRestoreServers | Launch restore servers
[**ProjectsProjectIdMoveMachinesPost**](ActionsApi.md#projectsprojectidmovemachinespost) | **POST** /projects/{projectId}/moveMachines | Moves machines to another project
[**ProjectsProjectIdPauseReplicationPost**](ActionsApi.md#projectsprojectidpausereplicationpost) | **POST** /projects/{projectId}/pauseReplication | Pause replication
[**ProjectsProjectIdReplicasDelete**](ActionsApi.md#projectsprojectidreplicasdelete) | **DELETE** /projects/{projectId}/replicas | Perform Cleanup
[**ProjectsProjectIdReverseReplicationPost**](ActionsApi.md#projectsprojectidreversereplicationpost) | **POST** /projects/{projectId}/reverseReplication | Reverse replication direction
[**ProjectsProjectIdStartReplicationPost**](ActionsApi.md#projectsprojectidstartreplicationpost) | **POST** /projects/{projectId}/startReplication | Start replication
[**ProjectsProjectIdStopReplicationPost**](ActionsApi.md#projectsprojectidstopreplicationpost) | **POST** /projects/{projectId}/stopReplication | Stop replication

<a name="projectsprojectidjobsget"></a>
# **ProjectsProjectIdJobsGet**
> JobsList ProjectsProjectIdJobsGet (string projectId, int? offset = null, int? limit = null)

List Jobs

Returns the list of jobs in the project.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdJobsGetExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var projectId = projectId_example;  // string | 
            var offset = 56;  // int? | With which item to start (0 based). (optional)  (default to 0)
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)

            try
            {
                // List Jobs
                JobsList result = apiInstance.ProjectsProjectIdJobsGet(projectId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ProjectsProjectIdJobsGet: " + e.Message );
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

[**JobsList**](JobsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidjobsjobidget"></a>
# **ProjectsProjectIdJobsJobIdGet**
> Job ProjectsProjectIdJobsJobIdGet (string projectId, string jobId)

Get Job

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdJobsJobIdGetExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var projectId = projectId_example;  // string | 
            var jobId = jobId_example;  // string | 

            try
            {
                // Get Job
                Job result = apiInstance.ProjectsProjectIdJobsJobIdGet(projectId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ProjectsProjectIdJobsJobIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **jobId** | **string**|  | 

### Return type

[**Job**](Job.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidlaunchmachinespost"></a>
# **ProjectsProjectIdLaunchMachinesPost**
> Job ProjectsProjectIdLaunchMachinesPost (LaunchMachinesParameters body, string projectId)

Launch target machines

Launch target machines for test, recovery or cutover (by passing enum value to launchType param)

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdLaunchMachinesPostExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var body = new LaunchMachinesParameters(); // LaunchMachinesParameters | Machines to launch
            var projectId = projectId_example;  // string | 

            try
            {
                // Launch target machines
                Job result = apiInstance.ProjectsProjectIdLaunchMachinesPost(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ProjectsProjectIdLaunchMachinesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LaunchMachinesParameters**](LaunchMachinesParameters.md)| Machines to launch | 
 **projectId** | **string**|  | 

### Return type

[**Job**](Job.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidlaunchrestoreserverspost"></a>
# **ProjectsProjectIdLaunchRestoreServersPost**
> Job ProjectsProjectIdLaunchRestoreServersPost (LaunchMachinesParameters body, string projectId)

Launch restore servers

Launch restore servers for the Backup service

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdLaunchRestoreServersPostExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var body = new LaunchMachinesParameters(); // LaunchMachinesParameters | 
            var projectId = projectId_example;  // string | 

            try
            {
                // Launch restore servers
                Job result = apiInstance.ProjectsProjectIdLaunchRestoreServersPost(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ProjectsProjectIdLaunchRestoreServersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LaunchMachinesParameters**](LaunchMachinesParameters.md)|  | 
 **projectId** | **string**|  | 

### Return type

[**Job**](Job.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidmovemachinespost"></a>
# **ProjectsProjectIdMoveMachinesPost**
> void ProjectsProjectIdMoveMachinesPost (Body4 body, string projectId)

Moves machines to another project

TBC 

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdMoveMachinesPostExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var body = new Body4(); // Body4 | 
            var projectId = projectId_example;  // string | 

            try
            {
                // Moves machines to another project
                apiInstance.ProjectsProjectIdMoveMachinesPost(body, projectId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ProjectsProjectIdMoveMachinesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body4**](Body4.md)|  | 
 **projectId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidpausereplicationpost"></a>
# **ProjectsProjectIdPauseReplicationPost**
> MachinesListInvalidIDsAndJob ProjectsProjectIdPauseReplicationPost (Body9 body, string projectId)

Pause replication

Pause replication for given machines

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdPauseReplicationPostExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var body = new Body9(); // Body9 | The machine IDs for which to pause replication.
            var projectId = projectId_example;  // string | 

            try
            {
                // Pause replication
                MachinesListInvalidIDsAndJob result = apiInstance.ProjectsProjectIdPauseReplicationPost(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ProjectsProjectIdPauseReplicationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body9**](Body9.md)| The machine IDs for which to pause replication. | 
 **projectId** | **string**|  | 

### Return type

[**MachinesListInvalidIDsAndJob**](MachinesListInvalidIDsAndJob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidreplicasdelete"></a>
# **ProjectsProjectIdReplicasDelete**
> Job ProjectsProjectIdReplicasDelete (Body5 body, string projectId)

Perform Cleanup

Spawns a cleanup job to remove the specified target machines from the cloud. Returns the job information.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdReplicasDeleteExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var body = new Body5(); // Body5 | The list of replica IDs to delete (corresponding to the 'replica' field in the machine object.
            var projectId = projectId_example;  // string | 

            try
            {
                // Perform Cleanup
                Job result = apiInstance.ProjectsProjectIdReplicasDelete(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ProjectsProjectIdReplicasDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body5**](Body5.md)| The list of replica IDs to delete (corresponding to the &#x27;replica&#x27; field in the machine object. | 
 **projectId** | **string**|  | 

### Return type

[**Job**](Job.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidreversereplicationpost"></a>
# **ProjectsProjectIdReverseReplicationPost**
> void ProjectsProjectIdReverseReplicationPost (string projectId)

Reverse replication direction

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdReverseReplicationPostExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var projectId = projectId_example;  // string | 

            try
            {
                // Reverse replication direction
                apiInstance.ProjectsProjectIdReverseReplicationPost(projectId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ProjectsProjectIdReverseReplicationPost: " + e.Message );
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
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidstartreplicationpost"></a>
# **ProjectsProjectIdStartReplicationPost**
> MachinesListInvalidIDsAndJob ProjectsProjectIdStartReplicationPost (Body3 body, string projectId)

Start replication

Start replication of the specified source machines. Returns the machine for which replication has been successfully started, and the IDs for which replication could not be started.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdStartReplicationPostExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var body = new Body3(); // Body3 | Specification of the machines for which replication will start.
            var projectId = projectId_example;  // string | 

            try
            {
                // Start replication
                MachinesListInvalidIDsAndJob result = apiInstance.ProjectsProjectIdStartReplicationPost(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ProjectsProjectIdStartReplicationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body3**](Body3.md)| Specification of the machines for which replication will start. | 
 **projectId** | **string**|  | 

### Return type

[**MachinesListInvalidIDsAndJob**](MachinesListInvalidIDsAndJob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidstopreplicationpost"></a>
# **ProjectsProjectIdStopReplicationPost**
> MachinesListInvalidIDsAndJob ProjectsProjectIdStopReplicationPost (Body7 body, string projectId)

Stop replication

Stop replication of the specified source machines. Returns the machine for which replication has been successfully stopped, and the IDs for which replication could not be stopped.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdStopReplicationPostExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var body = new Body7(); // Body7 | Specification of the machines for which replication will stop.
            var projectId = projectId_example;  // string | 

            try
            {
                // Stop replication
                MachinesListInvalidIDsAndJob result = apiInstance.ProjectsProjectIdStopReplicationPost(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ProjectsProjectIdStopReplicationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body7**](Body7.md)| Specification of the machines for which replication will stop. | 
 **projectId** | **string**|  | 

### Return type

[**MachinesListInvalidIDsAndJob**](MachinesListInvalidIDsAndJob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
