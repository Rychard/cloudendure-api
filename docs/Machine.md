# CloudEndure.Model.Machine
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceProperties** | [**MachineSourceProperties**](MachineSourceProperties.md) |  | [optional] 
**ReplicationInfo** | [**MachineReplicationInfo**](MachineReplicationInfo.md) |  | [optional] 
**License** | [**MachineLicense**](MachineLicense.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**RestoreServers** | **List&lt;Guid?&gt;** | RestoreServer IDs  | [optional] 
**FromPointInTime** | [**PointInTime**](PointInTime.md) |  | [optional] 
**ReplicationStatus** | **string** | Is replication started, paused or stopped | [optional] 
**Replica** | **string** | The ID of the target machine that has been previously launched, if such exists. | [optional] 
**Id** | **string** |  | [optional] 
**ReplicationConfiguration** | [**MachineReplicationConfiguration**](MachineReplicationConfiguration.md) |  | [optional] 
**LifeCycle** | [**MachineLifeCycle**](MachineLifeCycle.md) |  | [optional] 
**IsAgentInstalled** | **bool?** | Whether a CloudEndure agent is currently installed on this machine. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

