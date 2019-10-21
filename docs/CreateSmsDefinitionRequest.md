# Salesforce.MarketingCloud.Model.CreateSmsDefinitionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefinitionKey** | **string** | Unique, user-generated key to access the definition object. | 
**Name** | **string** | Name of the definition. Must be unique. | 
**Content** | [**CreateSmsDefinitionContent**](CreateSmsDefinitionContent.md) |  | 
**Status** | **string** | Operational state of the definition: active, inactive, or deleted. A message sent to an active definition is processed and delivered. A message sent to an inactive definition isn’t processed or delivered. Instead, the message is queued for later processing for up to three days. | [optional] 
**CreatedDate** | **DateTime?** | The date the object was created. | [optional] 
**ModifiedDate** | **DateTime?** | The date the object was modified. | [optional] 
**Description** | **string** | User-provided description of the SMS definition. | [optional] 
**Subscriptions** | [**CreateSmsDefinitionSubscriptions**](CreateSmsDefinitionSubscriptions.md) |  | 
**RequestId** | **string** | The ID of the request | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

