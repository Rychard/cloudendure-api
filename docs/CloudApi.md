# CloudEndure.Api.CloudApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloudCredentialsCredsIdRegionsGet**](CloudApi.md#cloudcredentialscredsidregionsget) | **GET** /cloudCredentials/{credsId}/regions | List Regions
[**CloudCredentialsCredsIdRegionsRegionIdDelete**](CloudApi.md#cloudcredentialscredsidregionsregioniddelete) | **DELETE** /cloudCredentials/{credsId}/regions/{regionId} | Delete region (VCenter)
[**CloudCredentialsCredsIdRegionsRegionIdGet**](CloudApi.md#cloudcredentialscredsidregionsregionidget) | **GET** /cloudCredentials/{credsId}/regions/{regionId} | Get Region
[**CloudCredentialsCredsIdRegionsRegionIdPatch**](CloudApi.md#cloudcredentialscredsidregionsregionidpatch) | **PATCH** /cloudCredentials/{credsId}/regions/{regionId} | Patch region (rename)
[**CloudsGet**](CloudApi.md#cloudsget) | **GET** /clouds | List Clouds

<a name="cloudcredentialscredsidregionsget"></a>
# **CloudCredentialsCredsIdRegionsGet**
> RegionsList CloudCredentialsCredsIdRegionsGet (string credsId, int? offset = null, int? limit = null)

List Regions

Returns the list of regions these credentials provide access to.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class CloudCredentialsCredsIdRegionsGetExample
    {
        public void main()
        {
            var apiInstance = new CloudApi();
            var credsId = credsId_example;  // string | UUID of the credentials to use. In case of on-premise, you should use the null UUID \"00000000-0000-0000-0000-000000000000\". 
            var offset = 56;  // int? | With which item to start (0 based). (optional)  (default to 0)
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)

            try
            {
                // List Regions
                RegionsList result = apiInstance.CloudCredentialsCredsIdRegionsGet(credsId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudApi.CloudCredentialsCredsIdRegionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credsId** | **string**| UUID of the credentials to use. In case of on-premise, you should use the null UUID \&quot;00000000-0000-0000-0000-000000000000\&quot;.  | 
 **offset** | **int?**| With which item to start (0 based). | [optional] [default to 0]
 **limit** | **int?**| A number specifying how many entries to return. | [optional] [default to 1500]

### Return type

[**RegionsList**](RegionsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cloudcredentialscredsidregionsregioniddelete"></a>
# **CloudCredentialsCredsIdRegionsRegionIdDelete**
> void CloudCredentialsCredsIdRegionsRegionIdDelete (string credsId, string regionId)

Delete region (VCenter)

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class CloudCredentialsCredsIdRegionsRegionIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new CloudApi();
            var credsId = credsId_example;  // string | UUID of the credentials to use. In case of on-premise, you should use the null UUID \"00000000-0000-0000-0000-000000000000\". 
            var regionId = regionId_example;  // string | 

            try
            {
                // Delete region (VCenter)
                apiInstance.CloudCredentialsCredsIdRegionsRegionIdDelete(credsId, regionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudApi.CloudCredentialsCredsIdRegionsRegionIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credsId** | **string**| UUID of the credentials to use. In case of on-premise, you should use the null UUID \&quot;00000000-0000-0000-0000-000000000000\&quot;.  | 
 **regionId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cloudcredentialscredsidregionsregionidget"></a>
# **CloudCredentialsCredsIdRegionsRegionIdGet**
> Region CloudCredentialsCredsIdRegionsRegionIdGet (string credsId, string regionId)

Get Region

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class CloudCredentialsCredsIdRegionsRegionIdGetExample
    {
        public void main()
        {
            var apiInstance = new CloudApi();
            var credsId = credsId_example;  // string | UUID of the credentials to use. In case of on-premise, you should use the null UUID \"00000000-0000-0000-0000-000000000000\". 
            var regionId = regionId_example;  // string | 

            try
            {
                // Get Region
                Region result = apiInstance.CloudCredentialsCredsIdRegionsRegionIdGet(credsId, regionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudApi.CloudCredentialsCredsIdRegionsRegionIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credsId** | **string**| UUID of the credentials to use. In case of on-premise, you should use the null UUID \&quot;00000000-0000-0000-0000-000000000000\&quot;.  | 
 **regionId** | **string**|  | 

### Return type

[**Region**](Region.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cloudcredentialscredsidregionsregionidpatch"></a>
# **CloudCredentialsCredsIdRegionsRegionIdPatch**
> Region CloudCredentialsCredsIdRegionsRegionIdPatch (Region body, string credsId, string regionId)

Patch region (rename)

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class CloudCredentialsCredsIdRegionsRegionIdPatchExample
    {
        public void main()
        {
            var apiInstance = new CloudApi();
            var body = new Region(); // Region | 
            var credsId = credsId_example;  // string | UUID of the credentials to use. In case of on-premise, you should use the null UUID \"00000000-0000-0000-0000-000000000000\". 
            var regionId = regionId_example;  // string | 

            try
            {
                // Patch region (rename)
                Region result = apiInstance.CloudCredentialsCredsIdRegionsRegionIdPatch(body, credsId, regionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudApi.CloudCredentialsCredsIdRegionsRegionIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Region**](Region.md)|  | 
 **credsId** | **string**| UUID of the credentials to use. In case of on-premise, you should use the null UUID \&quot;00000000-0000-0000-0000-000000000000\&quot;.  | 
 **regionId** | **string**|  | 

### Return type

[**Region**](Region.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cloudsget"></a>
# **CloudsGet**
> CloudsList CloudsGet (int? offset = null, int? limit = null)

List Clouds

Returns a list of clouds that can be used with CloudEndure. The roles array determines whether this cloud can be used as source, target, or both.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class CloudsGetExample
    {
        public void main()
        {
            var apiInstance = new CloudApi();
            var offset = 56;  // int? | With which item to start (0 based). (optional)  (default to 0)
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)

            try
            {
                // List Clouds
                CloudsList result = apiInstance.CloudsGet(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudApi.CloudsGet: " + e.Message );
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

[**CloudsList**](CloudsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
