# CloudEndure.Model.Replica
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Machine** | **string** | The ID of the source machine for this target machine. | [optional] 
**CloudEndureCreationDateTime** | **DateTime?** | Timestamp for launching this target machine. | [optional] 
**Name** | **string** | Target machine name in the target environment. | [optional] 
**PointInTime** | **string** | The ID of the pointInTime object from which this target machine was created. | [optional] 
**JobId** | **string** |  | [optional] 
**MachineCloudState** | **string** | Target machine state in the target environment. | [optional] 
**PublicIps** | **List&lt;string&gt;** | Static (non-ephemral) public IPs. On some clouds this also includes ephemeral IPs. | [optional] 
**RegionId** | **string** | The ID of the region where this target machine has been launched. | [optional] 
**Id** | **string** |  | [optional] 
**MachineCloudId** | **string** | Target machine ID in the target environment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

