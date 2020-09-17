# CloudEndure.Model.Region
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subnets** | [**List&lt;Subnet&gt;**](Subnet.md) |  | [optional] 
**PlacementGroups** | **List&lt;string&gt;** |  | [optional] 
**ScsiAdapterTypes** | **List&lt;string&gt;** |  | [optional] 
**InstanceTypes** | **List&lt;string&gt;** |  | [optional] 
**Zones** | **List&lt;string&gt;** |  | [optional] 
**VolumeEncryptionKeys** | **List&lt;string&gt;** |  | [optional] 
**Cloud** | **string** |  | [optional] 
**SecurityGroups** | [**List&lt;SecurityGroup&gt;**](SecurityGroup.md) |  | [optional] 
**LogicalLocations** | [**List&lt;LogicalLocation&gt;**](LogicalLocation.md) |  | [optional] 
**StaticIps** | **List&lt;string&gt;** |  | [optional] 
**MaxCpusPerMachine** | **int?** | Maximum CPUs per per Target machine (currently relevant for vCenter cloud only) | [optional] 
**NetworkInterfaces** | [**List&lt;NetworkInterface&gt;**](NetworkInterface.md) |  | [optional] 
**ComputeLocations** | [**List&lt;ComputeLocation&gt;**](ComputeLocation.md) | Compute location (e.g. vCenter Host) | [optional] 
**Name** | **string** |  | [optional] 
**StorageLocations** | [**List&lt;StorageLocation&gt;**](StorageLocation.md) | Storage location (e.g. Azure Storage Account, vCenter Data Store) | [optional] 
**IamRoles** | **List&lt;string&gt;** |  | [optional] 
**Id** | **string** |  | [optional] 
**MaxCoresPerMachineCpu** | **int?** | Maximum CPU cores per CPU in Target machines (currently relevant for vCenter cloud only) | [optional] 
**DedicatedHosts** | **List&lt;string&gt;** |  | [optional] 
**NetworkAdapterTypes** | **List&lt;string&gt;** |  | [optional] 
**MaxMbRamPerMachine** | **int?** | Maximum MB RAM per Target machine (currently relevant for vCenter cloud only) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

