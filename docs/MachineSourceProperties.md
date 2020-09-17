# CloudEndure.Model.MachineSourceProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Machine name in the source environment. | [optional] 
**InstalledApplications** | [**MachineSourcePropertiesInstalledApplications**](MachineSourcePropertiesInstalledApplications.md) |  | [optional] 
**Disks** | [**List&lt;MachineSourcePropertiesDisks&gt;**](MachineSourcePropertiesDisks.md) | Identified disks. | [optional] 
**MachineCloudState** | **string** | Machine current state in the source environment. | [optional] 
**PublicIps** | **List&lt;string&gt;** | Static (non-ephemral) public IPs. On some clouds this also includes ephemeral IPs. | [optional] 
**Memory** | **int?** | Available RAM (in Bytes). | [optional] 
**Os** | **string** | Running Operating System. | [optional] 
**Cpu** | [**List&lt;MachineSourcePropertiesCpu&gt;**](MachineSourcePropertiesCpu.md) | Identified CPUs. | [optional] 
**RunningServices** | [**MachineSourcePropertiesRunningServices**](MachineSourcePropertiesRunningServices.md) |  | [optional] 
**MachineCloudId** | **string** | Machine ID in the source environment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

