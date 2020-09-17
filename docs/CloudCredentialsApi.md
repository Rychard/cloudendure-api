# CloudEndure.Api.CloudCredentialsApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloudCredentialsCredsIdGet**](CloudCredentialsApi.md#cloudcredentialscredsidget) | **GET** /cloudCredentials/{credsId} | Get Credentials
[**CloudCredentialsCredsIdPatch**](CloudCredentialsApi.md#cloudcredentialscredsidpatch) | **PATCH** /cloudCredentials/{credsId} | Change Credentials
[**CloudCredentialsGet**](CloudCredentialsApi.md#cloudcredentialsget) | **GET** /cloudCredentials | List Credentials
[**CloudCredentialsPost**](CloudCredentialsApi.md#cloudcredentialspost) | **POST** /cloudCredentials | Create Credentials

<a name="cloudcredentialscredsidget"></a>
# **CloudCredentialsCredsIdGet**
> CloudCredentials CloudCredentialsCredsIdGet (string credsId)

Get Credentials

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class CloudCredentialsCredsIdGetExample
    {
        public void main()
        {
            var apiInstance = new CloudCredentialsApi();
            var credsId = credsId_example;  // string | UUID of the credentials to use. In case of on-premise, you should use the null UUID \"00000000-0000-0000-0000-000000000000\". 

            try
            {
                // Get Credentials
                CloudCredentials result = apiInstance.CloudCredentialsCredsIdGet(credsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudCredentialsApi.CloudCredentialsCredsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credsId** | **string**| UUID of the credentials to use. In case of on-premise, you should use the null UUID \&quot;00000000-0000-0000-0000-000000000000\&quot;.  | 

### Return type

[**CloudCredentials**](CloudCredentials.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cloudcredentialscredsidpatch"></a>
# **CloudCredentialsCredsIdPatch**
> CloudCredentials CloudCredentialsCredsIdPatch (CloudCredentialsRequest body, string credsId)

Change Credentials

Changes the cloud credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class CloudCredentialsCredsIdPatchExample
    {
        public void main()
        {
            var apiInstance = new CloudCredentialsApi();
            var body = new CloudCredentialsRequest(); // CloudCredentialsRequest | 
            var credsId = credsId_example;  // string | UUID of the credentials to use. In case of on-premise, you should use the null UUID \"00000000-0000-0000-0000-000000000000\". 

            try
            {
                // Change Credentials
                CloudCredentials result = apiInstance.CloudCredentialsCredsIdPatch(body, credsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudCredentialsApi.CloudCredentialsCredsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CloudCredentialsRequest**](CloudCredentialsRequest.md)|  | 
 **credsId** | **string**| UUID of the credentials to use. In case of on-premise, you should use the null UUID \&quot;00000000-0000-0000-0000-000000000000\&quot;.  | 

### Return type

[**CloudCredentials**](CloudCredentials.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cloudcredentialsget"></a>
# **CloudCredentialsGet**
> CloudCredentialsList CloudCredentialsGet (int? offset = null, int? limit = null)

List Credentials

Returns the list of cloudCredentials in the account.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class CloudCredentialsGetExample
    {
        public void main()
        {
            var apiInstance = new CloudCredentialsApi();
            var offset = 56;  // int? | With which item to start (0 based). (optional)  (default to 0)
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)

            try
            {
                // List Credentials
                CloudCredentialsList result = apiInstance.CloudCredentialsGet(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudCredentialsApi.CloudCredentialsGet: " + e.Message );
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

[**CloudCredentialsList**](CloudCredentialsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cloudcredentialspost"></a>
# **CloudCredentialsPost**
> CloudCredentials CloudCredentialsPost (CloudCredentialsRequest body)

Create Credentials

Provide the credentials with which to access the cloud API. Returns the newly created object.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class CloudCredentialsPostExample
    {
        public void main()
        {
            var apiInstance = new CloudCredentialsApi();
            var body = new CloudCredentialsRequest(); // CloudCredentialsRequest | 

            try
            {
                // Create Credentials
                CloudCredentials result = apiInstance.CloudCredentialsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudCredentialsApi.CloudCredentialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CloudCredentialsRequest**](CloudCredentialsRequest.md)|  | 

### Return type

[**CloudCredentials**](CloudCredentials.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
