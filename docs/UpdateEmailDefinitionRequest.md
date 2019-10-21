# Salesforce.MarketingCloud.Model.UpdateEmailDefinitionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the definition. Must be unique. | [optional] 
**Content** | [**CreateEmailDefinitionContent**](CreateEmailDefinitionContent.md) |  | [optional] 
**Status** | **string** | Operational state of the definition: active, inactive, or deleted. A message sent to an active definition is processed and delivered. A message sent to an inactive definition isn’t processed or delivered. Instead, the message is queued for later processing for up to three days. | [optional] 
**Description** | **string** | User-provided description of the email definition. | [optional] 
**Classification** | **string** | Marketing Cloud external key of a sending classification defined in Email Studio Administration. Only transactional classifications are permitted. Default is default transactional. | [optional] 
**Subscriptions** | [**CreateEmailDefinitionSubscriptions**](CreateEmailDefinitionSubscriptions.md) |  | [optional] 
**Options** | [**CreateEmailDefinitionOptionsRequest**](CreateEmailDefinitionOptionsRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

