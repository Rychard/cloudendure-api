# CloudEndure.Model.MachineReplicationInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RescannedStorageBytes** | **long?** | Amount of data rescanned (in Bytes). | [optional] 
**BackloggedStorageBytes** | **long?** | Amount of data requiring sync (in Bytes), that has not yet been sent. | [optional] 
**LastConsistencyDateTime** | **DateTime?** | Timestamp of last disk replication consistency event. | [optional] 
**NextConsistencyEstimatedDateTime** | **DateTime?** | Timestamp of estimate for the next disk replication consistency event. | [optional] 
**TotalStorageBytes** | **long?** | Total storage being replicated (in Bytes). | [optional] 
**InitiationStates** | [**MachineReplicationInfoInitiationStates**](MachineReplicationInfoInitiationStates.md) |  | [optional] 
**ReplicatedStorageBytes** | **long?** | Amount of data already synced (in Bytes). | [optional] 
**LastSeenDateTime** | **DateTime?** |  | [optional] 
**LastScanStartDateTime** | **DateTime?** | Timestamp of last time a volume scan has started. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

