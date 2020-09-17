# CloudEndure.Model.CloudCredentialsRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PublicKey** | **string** | The public part of the Cloud credentials. For AWS - The access key ID, For GCP and Azure - N/A. | [optional] 
**Name** | **string** | An optional (can be empty), user provided, descriptive name. | [optional] 
**CloudId** | **string** |  | 
**PrivateKey** | **byte[]** | Cloud credentials secret, Base64-encoded. For AWS - The secret access key, For GCP - The private key in JSON format, For Azure - The certificate file. | [optional] 
**AccountIdentifier** | **string** | Cloud account identifier. For AWS - N/A, For GCP - The project ID, For Azure - The subscription ID. | [optional] 
**Id** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

