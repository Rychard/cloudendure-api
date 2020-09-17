# CloudEndure.Model.Blueprint
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IamRole** | **string** | AWS only. Possible values can be fetched from the Region object. | [optional] 
**ScsiAdapterType** | **string** | Currently relevant for vCenter cloud only. Possible values can be fetched from the Region object. | [optional] 
**PublicIPAction** | **string** | Whether to allocate an ephemeral public IP, or not. AS_SUBNET causes CloudEndure to copy this property from the source machine. | [optional] 
**MachineName** | **string** |  | [optional] 
**Cpus** | **int?** | Number of CPUs per per Target machine; Currently relevant for vCenter cloud only; Max value can be fetched from the maxCpusPerMachine property of the Region object.  | [optional] 
**SecurityGroupIDs** | **List&lt;string&gt;** | AWS only. The security groups that will be applied to the target machine. Possible values can be fetched from the Region object. | [optional] 
**RunAfterLaunch** | **bool?** | AWS only. Whether to power on the launched target machine after launch. True by default. | [optional] 
**RecommendedPrivateIP** | **string** | The private IP address recommended for use with this machine. | [optional] 
**NetworkInterface** | **string** |  | [optional] 
**Id** | **string** |  | [optional] 
**MbRam** | **int?** | MB RAM per Target machine; Currently relevant for vCenter cloud only; Max value can be fetched from the maxMbRamPerMachine property of the Region object.  | [optional] 
**InstanceType** | **string** | Possible values can be fetched from the Region object, plus special values \&quot;COPY_ORIGIN\&quot; or \&quot;CUSTOM\&quot; | [optional] 
**SubnetIDs** | **List&lt;string&gt;** | AWS only. Configures a subnets in which the instance network interface will take part. Possible values can be fetched from the Region object. | [optional] 
**CoresPerCpu** | **int?** | Number of CPU cores per CPU in Target machine; Currently relevant for vCenter cloud only. | [optional] 
**RecommendedInstanceType** | **string** | When instance rightsizing is enabled, the instance type suitable for the source machine&#x27;s HW | [optional] 
**StaticIp** | **string** | Possible values can be fetched from the Region object. | [optional] 
**LaunchOnInstanceId** | **string** | instance id for target machine managed by AMS. | [optional] 
**Tags** | [**List&lt;ReplicationConfigurationReplicationTags&gt;**](ReplicationConfigurationReplicationTags.md) | AWS only. Tags that will be applied to the target machine. | [optional] 
**SecurityGroupAction** | **string** | How to assign a security group to the target machine. | [optional] 
**PrivateIPs** | **List&lt;string&gt;** |  | [optional] 
**Tenancy** | **string** |  | [optional] 
**ComputeLocationId** | **string** |  | [optional] 
**SubnetsHostProject** | **string** | GCP only. Host project for cross project network subnet. | [optional] 
**LogicalLocationId** | **string** | vcenter &#x3D; vmFolder; relates to $ref LogicalLocation | [optional] 
**NetworkAdapterType** | **string** | Currently relevant for vCenter cloud only. Possible values can be fetched from the Region object. | [optional] 
**ByolOnDedicatedInstance** | **bool?** | specifies whether to use byol windows license if dedicated instance tenancy is selected. | [optional] 
**PlacementGroup** | **string** | AWS only. Possible values can be fetched from the Region object. | [optional] 
**MachineId** | **string** |  | [optional] 
**Region** | **string** |  | [optional] 
**Disks** | [**List&lt;BlueprintDisks&gt;**](BlueprintDisks.md) | AWS only. Target machine disk properties. | [optional] 
**PrivateIPAction** | **string** |  | [optional] 
**StaticIpAction** | **string** |  | [optional] 
**DedicatedHostIdentifier** | **string** |  | [optional] 
**UseSharedRam** | **bool?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

