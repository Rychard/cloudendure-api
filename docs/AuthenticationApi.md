# CloudEndure.Api.AuthenticationApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LoginPost**](AuthenticationApi.md#loginpost) | **POST** /login | Login
[**LogoutPost**](AuthenticationApi.md#logoutpost) | **POST** /logout | Logout

<a name="loginpost"></a>
# **LoginPost**
> User LoginPost (Body1 body)

Login

Upon successful authentication, this method returns a session identifier cookie that can be used to authenticate subsequent API calls. 

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class LoginPostExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var body = new Body1(); // Body1 | Login info

            try
            {
                // Login
                User result = apiInstance.LoginPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.LoginPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body1**](Body1.md)| Login info | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="logoutpost"></a>
# **LogoutPost**
> void LogoutPost ()

Logout

Invalidates the session identifier associated with this session.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class LogoutPostExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();

            try
            {
                // Logout
                apiInstance.LogoutPost();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.LogoutPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
