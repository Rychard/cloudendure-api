# CloudEndure.Api.UserApi

All URIs are relative to *https://console.cloudendure.com/api/latest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangePasswordPost**](UserApi.md#changepasswordpost) | **POST** /changePassword | Change Password
[**MeGet**](UserApi.md#meget) | **GET** /me | Me
[**UsersUserIdDelete**](UserApi.md#usersuseriddelete) | **DELETE** /users/{userId} | Delete a User
[**UsersUserIdPatch**](UserApi.md#usersuseridpatch) | **PATCH** /users/{userId} | Modify user settings

<a name="changepasswordpost"></a>
# **ChangePasswordPost**
> void ChangePasswordPost (Body body)

Change Password

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class ChangePasswordPostExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var body = new Body(); // Body | 

            try
            {
                // Change Password
                apiInstance.ChangePasswordPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ChangePasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="meget"></a>
# **MeGet**
> User MeGet ()

Me

Provides user configuration information for the currently logged in user.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class MeGetExample
    {
        public void main()
        {
            var apiInstance = new UserApi();

            try
            {
                // Me
                User result = apiInstance.MeGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.MeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersuseriddelete"></a>
# **UsersUserIdDelete**
> void UsersUserIdDelete (string userId)

Delete a User

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class UsersUserIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userId = userId_example;  // string | 

            try
            {
                // Delete a User
                apiInstance.UsersUserIdDelete(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UsersUserIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersuseridpatch"></a>
# **UsersUserIdPatch**
> User UsersUserIdPatch (User body, string userId)

Modify user settings

Configure which projects this user can receive e-mail notifications for.

### Example
```csharp
using System;
using System.Diagnostics;
using CloudEndure.Api;
using CloudEndure.Client;
using CloudEndure.Model;

namespace Example
{
    public class UsersUserIdPatchExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var body = new User(); // User | 
            var userId = userId_example;  // string | 

            try
            {
                // Modify user settings
                User result = apiInstance.UsersUserIdPatch(body, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UsersUserIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**User**](User.md)|  | 
 **userId** | **string**|  | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
