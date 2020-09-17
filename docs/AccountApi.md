# CloudEndure.Api.AccountApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsAccountIdGet**](AccountApi.md#accountsaccountidget) | **GET** /accounts/{accountId} | Get Account information

<a name="accountsaccountidget"></a>
# **AccountsAccountIdGet**
> Account AccountsAccountIdGet (string accountId)

Get Account information

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class AccountsAccountIdGetExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var accountId = accountId_example;  // string | 

            try
            {
                // Get Account information
                Account result = apiInstance.AccountsAccountIdGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AccountsAccountIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
