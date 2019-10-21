# Salesforce.MarketingCloud.Model.CreateEmailDefinitionSubscriptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**List** | **string** | Marketing Cloud external key of the list or all subscribers. Contains the subscriber keys and profile attributes. | 
**DataExtension** | **string** | Marketing Cloud external key of the triggered send data extension. Each request inserts as a new row in the data extension. | [optional] 
**AutoAddSubscriber** | **bool?** | Adds the recipient’s email address and contact key as a subscriber key to subscriptions.list. Default is true. | [optional] [default to true]
**UpdateSubscriber** | **bool?** | Updates the recipient’s contact key as a subscriber key with the provided email address and profile attributes to subscriptions.list. Default is true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

