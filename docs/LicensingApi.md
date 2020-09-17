# CloudEndure.Api.LicensingApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LicensesGet**](LicensingApi.md#licensesget) | **GET** /licenses | List Licenses
[**LicensesLicenseIdGet**](LicensingApi.md#licenseslicenseidget) | **GET** /licenses/{licenseId} | Get License

<a name="licensesget"></a>
# **LicensesGet**
> LicenseList LicensesGet (int? offset = null, int? limit = null)

List Licenses

Returns the list of licenses currently associated with this user.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class LicensesGetExample
    {
        public void main()
        {
            var apiInstance = new LicensingApi();
            var offset = 56;  // int? | With which item to start (0 based). (optional)  (default to 0)
            var limit = 56;  // int? | A number specifying how many entries to return. (optional)  (default to 1500)

            try
            {
                // List Licenses
                LicenseList result = apiInstance.LicensesGet(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicensingApi.LicensesGet: " + e.Message );
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

[**LicenseList**](LicenseList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="licenseslicenseidget"></a>
# **LicensesLicenseIdGet**
> License LicensesLicenseIdGet (string licenseId)

Get License

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class LicensesLicenseIdGetExample
    {
        public void main()
        {
            var apiInstance = new LicensingApi();
            var licenseId = licenseId_example;  // string | 

            try
            {
                // Get License
                License result = apiInstance.LicensesLicenseIdGet(licenseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicensingApi.LicensesLicenseIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **licenseId** | **string**|  | 

### Return type

[**License**](License.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
