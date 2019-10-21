# Salesforce.MarketingCloud.Model.Recipient
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactKey** | **string** | Unique identifier for a subscriber in Marketing Cloud. Each request must include a contactKey. You can use an existing subscriber key or create one at send time by using the recipient’s email address. | 
**To** | **string** | Channel address of the recipient. For email, it’s the recipient&#39;s email address. For SMS, it’s the recipient&#39;s E.164-based mobile number. | [optional] 
**MessageKey** | **string** | Unique identifier used to track message status. Can be automatically created when you create a message or provided as part of the request. Each recipient in a request must have a unique messageKey. If you use a duplicate messageKey in the same send request, the message is rejected. | [optional] 
**Attributes** | [**Attributes**](Attributes.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

