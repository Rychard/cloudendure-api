# CloudEndure.Model.ReplicationConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeEncryptionKey** | **string** | AWS only. ARN to private key for Volume Encryption. Possible values can be fetched from the Region object. | [optional] 
**ReplicationTags** | [**List&lt;ReplicationConfigurationReplicationTags&gt;**](ReplicationConfigurationReplicationTags.md) | AWS only. Tags that will be applied to every cloud resource created in the CloudEndure Staging Area. | [optional] 
**DisablePublicIp** | **bool?** | When private IP is used, do not allocate public IP for replication server | [optional] 
**SubnetHostProject** | **string** | GCP only. Host project of cross project network subnet. | [optional] 
**ReplicationSoftwareDownloadSource** | **string** |  | [optional] 
**ReplicationServerType** | **string** |  | [optional] 
**UseLowCostDisks** | **bool?** | use low cost disks for replication whenever possible | [optional] 
**ComputeLocationId** | **string** |  | [optional] 
**CloudCredentials** | **string** | The ID for the cloudCredentials object containing the credentials to be used for accessing the target cloud. | [optional] 
**SubnetId** | **string** | Subnet where replication servers will be created. Possible values can be fetched from the Region object. | [optional] 
**LogicalLocationId** | **string** | vcenter &#x3D; vmFolder | [optional] 
**BandwidthThrottling** | **int?** | Mbps to use for Data Replication (zero means no throttling). | [optional] 
**UseDedicatedServer** | **bool?** |  | [optional] 
**Zone** | **string** | Relevant for GCP and Azure ARM. The Zone to replicate into. | [optional] 
**ReplicatorSecurityGroupIDs** | **List&lt;string&gt;** | AWS only. The security groups that will be applied to the replication servers. Possible values can be fetched from the Region object. | [optional] 
**UsePrivateIp** | **bool?** | Should the CloudEndure agent access the replication server using its private IP address. | [optional] 
**Region** | **string** |  | [optional] 
**Id** | **string** |  | [optional] 
**ProxyUrl** | **string** | The full URI for a proxy (schema, username, password, domain, port) if required for the CloudEndure agent. | [optional] 
**VolumeEncryptionAllowed** | **bool?** |  | [optional] 
**ObjectStorageLocation** | **string** | bucket in aws  | [optional] 
**ArchivingEnabled** | **bool?** |  | [optional] 
**ConverterType** | **string** |  | [optional] 
**StorageLocationId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

