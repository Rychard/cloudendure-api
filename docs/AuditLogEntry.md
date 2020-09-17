# CloudEndure.Model.AuditLogEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Username** | **string** | username (typically an email) of user who initiated action (in UI or via API) which resulted in this audit log entry being added.  | [optional] 
**EventName** | **string** | Unique event name.  One of:  - replicationConfigurationChanged  - blueprintChanged  | [optional] 
**ParticipatingMachines** | [**List&lt;AuditLogEntryParticipatingMachines&gt;**](AuditLogEntryParticipatingMachines.md) | List of machine-identifiers objects.  Only present if Audit Log entry relates to one or more machines.  | [optional] 
**Description** | **string** | Long-form human-readable description of Audit Log entry. | [optional] 
**ChangedFields** | [**List&lt;AuditLogChangedField&gt;**](AuditLogChangedField.md) | Map of fields that have been changed and their old an new values. Only present when eventName is replicationConfigurationChanged or blueprintChanged  | [optional] 
**Timestamp** | **DateTime?** | RFC 3339 compliant date-time string of when Audit Log entry was created/ event described by audit log entry happened.  | [optional] 
**JobId** | **string** | ID of Job due to which this log entry was created (only included if log entry is result of a Job) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

