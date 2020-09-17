# CloudEndure.Api.ReplicationApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProjectsProjectIdMachinesMachineIdBandwidthThrottlingGet**](ReplicationApi.md#projectsprojectidmachinesmachineidbandwidththrottlingget) | **GET** /projects/{projectId}/machines/{machineId}/bandwidthThrottling | Get value of network bandwidth throttling setting for Machine
[**ProjectsProjectIdMachinesMachineIdBandwidthThrottlingPatch**](ReplicationApi.md#projectsprojectidmachinesmachineidbandwidththrottlingpatch) | **PATCH** /projects/{projectId}/machines/{machineId}/bandwidthThrottling | Set value of network bandwidth throttling setting for Machine
[**ProjectsProjectIdMachinesMachineIdDelete**](ReplicationApi.md#projectsprojectidmachinesmachineiddelete) | **DELETE** /projects/{projectId}/machines/{machineId} | Uninstall agent
[**ProjectsProjectIdMachinesMachineIdPointsintimeGet**](ReplicationApi.md#projectsprojectidmachinesmachineidpointsintimeget) | **GET** /projects/{projectId}/machines/{machineId}/pointsintime | List Available Points-in-time
[**ProjectsProjectIdReplicationConfigurationsGet**](ReplicationApi.md#projectsprojectidreplicationconfigurationsget) | **GET** /projects/{projectId}/replicationConfigurations | List Replication Configurations
[**ProjectsProjectIdReplicationConfigurationsPost**](ReplicationApi.md#projectsprojectidreplicationconfigurationspost) | **POST** /projects/{projectId}/replicationConfigurations | Create Replication Configuration
[**ProjectsProjectIdReplicationConfigurationsReplicationConfigurationIdPatch**](ReplicationApi.md#projectsprojectidreplicationconfigurationsreplicationconfigurationidpatch) | **PATCH** /projects/{projectId}/replicationConfigurations/{replicationConfigurationId} | Modify Replication Configuration

<a name="projectsprojectidmachinesmachineidbandwidththrottlingget"></a>
# **ProjectsProjectIdMachinesMachineIdBandwidthThrottlingGet**
> BandwidthThrottling ProjectsProjectIdMachinesMachineIdBandwidthThrottlingGet (string projectId, string machineId)

Get value of network bandwidth throttling setting for Machine

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdMachinesMachineIdBandwidthThrottlingGetExample
    {
        public void main()
        {
            var apiInstance = new ReplicationApi();
            var projectId = projectId_example;  // string | 
            var machineId = machineId_example;  // string | 

            try
            {
                // Get value of network bandwidth throttling setting for Machine
                BandwidthThrottling result = apiInstance.ProjectsProjectIdMachinesMachineIdBandwidthThrottlingGet(projectId, machineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplicationApi.ProjectsProjectIdMachinesMachineIdBandwidthThrottlingGet: " + e.Message );
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

[**BandwidthThrottling**](BandwidthThrottling.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidmachinesmachineidbandwidththrottlingpatch"></a>
# **ProjectsProjectIdMachinesMachineIdBandwidthThrottlingPatch**
> BandwidthThrottling ProjectsProjectIdMachinesMachineIdBandwidthThrottlingPatch (BandwidthThrottling body, string projectId, string machineId)

Set value of network bandwidth throttling setting for Machine

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdMachinesMachineIdBandwidthThrottlingPatchExample
    {
        public void main()
        {
            var apiInstance = new ReplicationApi();
            var body = new BandwidthThrottling(); // BandwidthThrottling | 
            var projectId = projectId_example;  // string | 
            var machineId = machineId_example;  // string | 

            try
            {
                // Set value of network bandwidth throttling setting for Machine
                BandwidthThrottling result = apiInstance.ProjectsProjectIdMachinesMachineIdBandwidthThrottlingPatch(body, projectId, machineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplicationApi.ProjectsProjectIdMachinesMachineIdBandwidthThrottlingPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BandwidthThrottling**](BandwidthThrottling.md)|  | 
 **projectId** | **string**|  | 
 **machineId** | **string**|  | 

### Return type

[**BandwidthThrottling**](BandwidthThrottling.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
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
            var apiInstance = new ReplicationApi();
            var projectId = projectId_example;  // string | 
            var machineId = machineId_example;  // string | 

            try
            {
                // Uninstall agent
                apiInstance.ProjectsProjectIdMachinesMachineIdDelete(projectId, machineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplicationApi.ProjectsProjectIdMachinesMachineIdDelete: " + e.Message );
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
<a name="projectsprojectidmachinesmachineidpointsintimeget"></a>
# **ProjectsProjectIdMachinesMachineIdPointsintimeGet**
> PointInTimeList ProjectsProjectIdMachinesMachineIdPointsintimeGet (string projectId, string machineId, int? offset = null, int? limit = null)

List Available Points-in-time

Returns the list of available recovery points for this machine.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdMachinesMachineIdPointsintimeGetExample
    {
        public void main()
        {
            var apiInstance = new ReplicationApi();
            var projectId = projectId_example;  // string | 
            var machineId = machineId_example;  // string | 
            var offset = 56;  // int? | With which item to start (0 based). (optional)  (default to 0)
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)

            try
            {
                // List Available Points-in-time
                PointInTimeList result = apiInstance.ProjectsProjectIdMachinesMachineIdPointsintimeGet(projectId, machineId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplicationApi.ProjectsProjectIdMachinesMachineIdPointsintimeGet: " + e.Message );
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
 **offset** | **int?**| With which item to start (0 based). | [optional] [default to 0]
 **limit** | **int?**| A number specifying how many entries to return. | [optional] [default to 1500]

### Return type

[**PointInTimeList**](PointInTimeList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidreplicationconfigurationsget"></a>
# **ProjectsProjectIdReplicationConfigurationsGet**
> ReplicationConfigurationList ProjectsProjectIdReplicationConfigurationsGet (string projectId, int? offset = null, int? limit = null)

List Replication Configurations

Returns the list of replication configuration objects defined in this project.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdReplicationConfigurationsGetExample
    {
        public void main()
        {
            var apiInstance = new ReplicationApi();
            var projectId = projectId_example;  // string | 
            var offset = 56;  // int? | With which item to start (0 based). (optional)  (default to 0)
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)

            try
            {
                // List Replication Configurations
                ReplicationConfigurationList result = apiInstance.ProjectsProjectIdReplicationConfigurationsGet(projectId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplicationApi.ProjectsProjectIdReplicationConfigurationsGet: " + e.Message );
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

[**ReplicationConfigurationList**](ReplicationConfigurationList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidreplicationconfigurationspost"></a>
# **ProjectsProjectIdReplicationConfigurationsPost**
> ReplicationConfiguration ProjectsProjectIdReplicationConfigurationsPost (ReplicationConfiguration body, string projectId)

Create Replication Configuration

Control Data Replication parameters such as target cloud credentials, Staging Area and replication network configuration. A single configuration can exist per target region. Returns the newly created object. 

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdReplicationConfigurationsPostExample
    {
        public void main()
        {
            var apiInstance = new ReplicationApi();
            var body = new ReplicationConfiguration(); // ReplicationConfiguration | 
            var projectId = projectId_example;  // string | 

            try
            {
                // Create Replication Configuration
                ReplicationConfiguration result = apiInstance.ProjectsProjectIdReplicationConfigurationsPost(body, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplicationApi.ProjectsProjectIdReplicationConfigurationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReplicationConfiguration**](ReplicationConfiguration.md)|  | 
 **projectId** | **string**|  | 

### Return type

[**ReplicationConfiguration**](ReplicationConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="projectsprojectidreplicationconfigurationsreplicationconfigurationidpatch"></a>
# **ProjectsProjectIdReplicationConfigurationsReplicationConfigurationIdPatch**
> ReplicationConfiguration ProjectsProjectIdReplicationConfigurationsReplicationConfigurationIdPatch (ReplicationConfiguration body, string projectId, string replicationConfigurationId)

Modify Replication Configuration

Modifying volumeEncryptionKey or modifying cloudCredentials to ones matching a different cloud account will result in replication restarting from initial sync. Returns the modified object.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ProjectsProjectIdReplicationConfigurationsReplicationConfigurationIdPatchExample
    {
        public void main()
        {
            var apiInstance = new ReplicationApi();
            var body = new ReplicationConfiguration(); // ReplicationConfiguration | 
            var projectId = projectId_example;  // string | 
            var replicationConfigurationId = replicationConfigurationId_example;  // string | 

            try
            {
                // Modify Replication Configuration
                ReplicationConfiguration result = apiInstance.ProjectsProjectIdReplicationConfigurationsReplicationConfigurationIdPatch(body, projectId, replicationConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplicationApi.ProjectsProjectIdReplicationConfigurationsReplicationConfigurationIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReplicationConfiguration**](ReplicationConfiguration.md)|  | 
 **projectId** | **string**|  | 
 **replicationConfigurationId** | **string**|  | 

### Return type

[**ReplicationConfiguration**](ReplicationConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
