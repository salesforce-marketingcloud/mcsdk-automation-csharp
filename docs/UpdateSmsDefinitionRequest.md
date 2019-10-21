# Salesforce.MarketingCloud.Model.UpdateSmsDefinitionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the definition. Must be unique. | [optional] 
**Content** | [**CreateSmsDefinitionContent**](CreateSmsDefinitionContent.md) |  | [optional] 
**Status** | **string** | Operational state of the definition: active, inactive, or deleted. A message sent to an active definition is processed and delivered. A message sent to an inactive definition isn’t processed or delivered. Instead, the message is queued for later processing for up to three days. | [optional] 
**Description** | **string** | User-provided description of the SMS definition. | [optional] 
**Subscriptions** | [**CreateSmsDefinitionSubscriptions**](CreateSmsDefinitionSubscriptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

