# Salesforce.MarketingCloud.Model.EmailDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | **string** | The ID of the request | [optional] 
**Name** | **string** | Name of the definition. Must be unique. | 
**DefinitionKey** | **string** | Unique, user-generated key to access the definition object. | 
**DefinitionId** | **string** | Definition Id | [optional] 
**Description** | **string** | User-provided description of the email definition. | [optional] 
**Classification** | **string** | Marketing Cloud external key of a sending classification defined in Email Studio Administration. Only transactional classifications are permitted. Default is default transactional. | [optional] 
**Status** | **string** | Operational state of the definition: active, inactive, or deleted. A message sent to an active definition is processed and delivered. A message sent to an inactive definition isn’t processed or delivered. Instead, the message is queued for later processing for up to three days. | [optional] 
**CreatedDate** | **DateTime?** | The date the object was created. | [optional] 
**ModifiedDate** | **DateTime?** | The date the object was modified. | [optional] 
**Content** | [**EmailDefinitionContent**](EmailDefinitionContent.md) |  | 
**Subscriptions** | [**EmailDefinitionSubscriptions**](EmailDefinitionSubscriptions.md) |  | 
**Options** | [**EmailDefinitionOptions**](EmailDefinitionOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

