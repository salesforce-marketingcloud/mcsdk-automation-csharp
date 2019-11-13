# Salesforce.MarketingCloud.Api.TransactionalMessagingApi

All URIs are relative to *https://www.exacttargetapis.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEmailDefinition**](TransactionalMessagingApi.md#createemaildefinition) | **POST** /messaging/v1/email/definitions/ | createEmailDefinition
[**CreateSmsDefinition**](TransactionalMessagingApi.md#createsmsdefinition) | **POST** /messaging/v1/sms/definitions | createSmsDefinition
[**DeleteEmailDefinition**](TransactionalMessagingApi.md#deleteemaildefinition) | **DELETE** /messaging/v1/email/definitions/{definitionKey} | deleteEmailDefinition
[**DeleteQueuedMessagesForEmailDefinition**](TransactionalMessagingApi.md#deletequeuedmessagesforemaildefinition) | **DELETE** /messaging/v1/email/definitions/{definitionKey}/queue | deleteQueuedMessagesForEmailDefinition
[**DeleteQueuedMessagesForSmsDefinition**](TransactionalMessagingApi.md#deletequeuedmessagesforsmsdefinition) | **DELETE** /messaging/v1/sms/definitions/{definitionKey}/queue | deleteQueuedMessagesForSmsDefinition
[**DeleteSmsDefinition**](TransactionalMessagingApi.md#deletesmsdefinition) | **DELETE** /messaging/v1/sms/definitions/{definitionKey} | deleteSmsDefinition
[**GetEmailDefinition**](TransactionalMessagingApi.md#getemaildefinition) | **GET** /messaging/v1/email/definitions/{definitionKey} | getEmailDefinition
[**GetEmailDefinitions**](TransactionalMessagingApi.md#getemaildefinitions) | **GET** /messaging/v1/email/definitions/ | getEmailDefinitions
[**GetEmailSendStatusForRecipient**](TransactionalMessagingApi.md#getemailsendstatusforrecipient) | **GET** /messaging/v1/email/messages/{messageKey} | getEmailSendStatusForRecipient
[**GetEmailsNotSentToRecipients**](TransactionalMessagingApi.md#getemailsnotsenttorecipients) | **GET** /messaging/v1/email/messages/ | getEmailsNotSentToRecipients
[**GetQueueMetricsForEmailDefinition**](TransactionalMessagingApi.md#getqueuemetricsforemaildefinition) | **GET** /messaging/v1/email/definitions/{definitionKey}/queue | getQueueMetricsForEmailDefinition
[**GetQueueMetricsForSmsDefinition**](TransactionalMessagingApi.md#getqueuemetricsforsmsdefinition) | **GET** /messaging/v1/sms/definitions/{definitionKey}/queue | getQueueMetricsForSmsDefinition
[**GetSMSsNotSentToRecipients**](TransactionalMessagingApi.md#getsmssnotsenttorecipients) | **GET** /messaging/v1/sms/messages/ | getSMSsNotSentToRecipients
[**GetSmsDefinition**](TransactionalMessagingApi.md#getsmsdefinition) | **GET** /messaging/v1/sms/definitions/{definitionKey} | getSmsDefinition
[**GetSmsDefinitions**](TransactionalMessagingApi.md#getsmsdefinitions) | **GET** /messaging/v1/sms/definitions | getSmsDefinitions
[**GetSmsSendStatusForRecipient**](TransactionalMessagingApi.md#getsmssendstatusforrecipient) | **GET** /messaging/v1/sms/messages/{messageKey} | getSmsSendStatusForRecipient
[**PartiallyUpdateEmailDefinition**](TransactionalMessagingApi.md#partiallyupdateemaildefinition) | **PATCH** /messaging/v1/email/definitions/{definitionKey} | partiallyUpdateEmailDefinition
[**PartiallyUpdateSmsDefinition**](TransactionalMessagingApi.md#partiallyupdatesmsdefinition) | **PATCH** /messaging/v1/sms/definitions/{definitionKey} | partiallyUpdateSmsDefinition
[**SendEmailToMultipleRecipients**](TransactionalMessagingApi.md#sendemailtomultiplerecipients) | **POST** /messaging/v1/email/messages/ | sendEmailToMultipleRecipients
[**SendEmailToSingleRecipient**](TransactionalMessagingApi.md#sendemailtosinglerecipient) | **POST** /messaging/v1/email/messages/{messageKey} | sendEmailToSingleRecipient
[**SendSmsToMultipleRecipients**](TransactionalMessagingApi.md#sendsmstomultiplerecipients) | **POST** /messaging/v1/sms/messages/ | sendSmsToMultipleRecipients
[**SendSmsToSingleRecipient**](TransactionalMessagingApi.md#sendsmstosinglerecipient) | **POST** /messaging/v1/sms/messages/{messageKey} | sendSmsToSingleRecipient


<a name="createemaildefinition"></a>
# **CreateEmailDefinition**
> CreateEmailDefinitionRequest CreateEmailDefinition (CreateEmailDefinitionRequest body)

createEmailDefinition

Creates the definition for an email.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class CreateEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var body = new CreateEmailDefinitionRequest(); // CreateEmailDefinitionRequest | JSON Parameters

            try
            {
                // createEmailDefinition
                CreateEmailDefinitionRequest result = apiInstance.CreateEmailDefinition(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.CreateEmailDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateEmailDefinitionRequest**](CreateEmailDefinitionRequest.md)| JSON Parameters | 

### Return type

[**CreateEmailDefinitionRequest**](CreateEmailDefinitionRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsmsdefinition"></a>
# **CreateSmsDefinition**
> CreateSmsDefinitionRequest CreateSmsDefinition (CreateSmsDefinitionRequest body)

createSmsDefinition

Creates the definition for an SMS.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class CreateSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var body = new CreateSmsDefinitionRequest(); // CreateSmsDefinitionRequest | JSON Parameters

            try
            {
                // createSmsDefinition
                CreateSmsDefinitionRequest result = apiInstance.CreateSmsDefinition(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.CreateSmsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateSmsDefinitionRequest**](CreateSmsDefinitionRequest.md)| JSON Parameters | 

### Return type

[**CreateSmsDefinitionRequest**](CreateSmsDefinitionRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemaildefinition"></a>
# **DeleteEmailDefinition**
> DeleteSendDefinitionResponse DeleteEmailDefinition (string definitionKey)

deleteEmailDefinition

Deletes an email definition. You can't restore a deleted definition. The deleted definition is archived, and a delete location of the definition key is provided in the response for reference. You can reuse a deleted definition key because the information associated with it is copied to a new unique identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to delete

            try
            {
                // deleteEmailDefinition
                DeleteSendDefinitionResponse result = apiInstance.DeleteEmailDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.DeleteEmailDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the definition to delete | 

### Return type

[**DeleteSendDefinitionResponse**](DeleteSendDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequeuedmessagesforemaildefinition"></a>
# **DeleteQueuedMessagesForEmailDefinition**
> DeleteQueuedMessagesForSendDefinitionResponse DeleteQueuedMessagesForEmailDefinition (string definitionKey)

deleteQueuedMessagesForEmailDefinition

Deletes the queue for an email definition. The email definition must be in inactive status.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteQueuedMessagesForEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the email definition

            try
            {
                // deleteQueuedMessagesForEmailDefinition
                DeleteQueuedMessagesForSendDefinitionResponse result = apiInstance.DeleteQueuedMessagesForEmailDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.DeleteQueuedMessagesForEmailDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the email definition | 

### Return type

[**DeleteQueuedMessagesForSendDefinitionResponse**](DeleteQueuedMessagesForSendDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequeuedmessagesforsmsdefinition"></a>
# **DeleteQueuedMessagesForSmsDefinition**
> DeleteQueuedMessagesForSendDefinitionResponse DeleteQueuedMessagesForSmsDefinition (string definitionKey)

deleteQueuedMessagesForSmsDefinition

Deletes the queue for a SMS definition. The SMS definition must be in inactive status.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteQueuedMessagesForSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the SMS definition

            try
            {
                // deleteQueuedMessagesForSmsDefinition
                DeleteQueuedMessagesForSendDefinitionResponse result = apiInstance.DeleteQueuedMessagesForSmsDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.DeleteQueuedMessagesForSmsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the SMS definition | 

### Return type

[**DeleteQueuedMessagesForSendDefinitionResponse**](DeleteQueuedMessagesForSendDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesmsdefinition"></a>
# **DeleteSmsDefinition**
> DeleteSendDefinitionResponse DeleteSmsDefinition (string definitionKey)

deleteSmsDefinition

Deletes an sms definition. You can't restore a deleted definition. The deleted definition is archived, and a delete location of the definition key is provided in the response for reference. You can reuse a deleted definition key because the information associated with it is copied to a new unique identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to delete

            try
            {
                // deleteSmsDefinition
                DeleteSendDefinitionResponse result = apiInstance.DeleteSmsDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.DeleteSmsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the definition to delete | 

### Return type

[**DeleteSendDefinitionResponse**](DeleteSendDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildefinition"></a>
# **GetEmailDefinition**
> CreateEmailDefinitionRequest GetEmailDefinition (string definitionKey)

getEmailDefinition

Gets email definition configuration details for a definition key.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to get

            try
            {
                // getEmailDefinition
                CreateEmailDefinitionRequest result = apiInstance.GetEmailDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetEmailDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the definition to get | 

### Return type

[**CreateEmailDefinitionRequest**](CreateEmailDefinitionRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildefinitions"></a>
# **GetEmailDefinitions**
> GetEmailDefinitionsResponse GetEmailDefinitions (string filter = null, decimal? pageSize = null, decimal? page = null, string orderBy = null)

getEmailDefinitions

Gets a list of email definitions.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetEmailDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var filter = filter_example;  // string | Filter by status type. Accepted values are active, inactive, or deleted. Valid operations are eq and neq. (optional) 
            var pageSize = 8.14;  // decimal? | Number of definitions, which are array elements, to return per paged response. (optional) 
            var page = 8.14;  // decimal? | Page number to return. (optional) 
            var orderBy = orderBy_example;  // string | Sort by a dimension. You can sort by only one dimension. Accepted values are definitionKey, name, createdDate, modifiedDate, and status. (optional) 

            try
            {
                // getEmailDefinitions
                GetEmailDefinitionsResponse result = apiInstance.GetEmailDefinitions(filter, pageSize, page, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetEmailDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Filter by status type. Accepted values are active, inactive, or deleted. Valid operations are eq and neq. | [optional] 
 **pageSize** | **decimal?**| Number of definitions, which are array elements, to return per paged response. | [optional] 
 **page** | **decimal?**| Page number to return. | [optional] 
 **orderBy** | **string**| Sort by a dimension. You can sort by only one dimension. Accepted values are definitionKey, name, createdDate, modifiedDate, and status. | [optional] 

### Return type

[**GetEmailDefinitionsResponse**](GetEmailDefinitionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsendstatusforrecipient"></a>
# **GetEmailSendStatusForRecipient**
> GetDefinitionSendStatusForRecipientResponse GetEmailSendStatusForRecipient (string messageKey)

getEmailSendStatusForRecipient

Gets the send status for a message. Because this route is rate-limited, use it for infrequent verification of a messageKey. To collect send status at scale, subscribe to transactional send events using the Event Notification Service.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetEmailSendStatusForRecipientExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var messageKey = messageKey_example;  // string | Unique identifier to track message send status. You must provide it in singleton requests using the recipient attribute. To provide it in batch requests, use the recipients array attribute. If you don’t provide the message key for recipients, it’s generated in the response.

            try
            {
                // getEmailSendStatusForRecipient
                GetDefinitionSendStatusForRecipientResponse result = apiInstance.GetEmailSendStatusForRecipient(messageKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetEmailSendStatusForRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageKey** | **string**| Unique identifier to track message send status. You must provide it in singleton requests using the recipient attribute. To provide it in batch requests, use the recipients array attribute. If you don’t provide the message key for recipients, it’s generated in the response. | 

### Return type

[**GetDefinitionSendStatusForRecipientResponse**](GetDefinitionSendStatusForRecipientResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsnotsenttorecipients"></a>
# **GetEmailsNotSentToRecipients**
> GetDefinitionsNotSentToRecipientsResponse GetEmailsNotSentToRecipients (string type, int? pageSize = null, int? lastEventId = null)

getEmailsNotSentToRecipients

Gets a paginated list of messages that were not sent, ordered from oldest to newest.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetEmailsNotSentToRecipientsExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var type = type_example;  // string | Only notSent is supported.
            var pageSize = 56;  // int? | Number of messageKeys (array elements) to return per response page. (optional) 
            var lastEventId = 56;  // int? | Event ID from which you want the response to start. To obtain the initial event ID, submit a request without a lastEventId. The events in the response are listed top to bottom from oldest to newest. (optional) 

            try
            {
                // getEmailsNotSentToRecipients
                GetDefinitionsNotSentToRecipientsResponse result = apiInstance.GetEmailsNotSentToRecipients(type, pageSize, lastEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetEmailsNotSentToRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Only notSent is supported. | 
 **pageSize** | **int?**| Number of messageKeys (array elements) to return per response page. | [optional] 
 **lastEventId** | **int?**| Event ID from which you want the response to start. To obtain the initial event ID, submit a request without a lastEventId. The events in the response are listed top to bottom from oldest to newest. | [optional] 

### Return type

[**GetDefinitionsNotSentToRecipientsResponse**](GetDefinitionsNotSentToRecipientsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqueuemetricsforemaildefinition"></a>
# **GetQueueMetricsForEmailDefinition**
> GetQueueMetricsForSendDefinitionResponse GetQueueMetricsForEmailDefinition (string definitionKey)

getQueueMetricsForEmailDefinition

Gets metrics for the messages of an email definition. Applies to messages that are accepted but not yet processed.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetQueueMetricsForEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the email definition

            try
            {
                // getQueueMetricsForEmailDefinition
                GetQueueMetricsForSendDefinitionResponse result = apiInstance.GetQueueMetricsForEmailDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetQueueMetricsForEmailDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the email definition | 

### Return type

[**GetQueueMetricsForSendDefinitionResponse**](GetQueueMetricsForSendDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqueuemetricsforsmsdefinition"></a>
# **GetQueueMetricsForSmsDefinition**
> GetQueueMetricsForSendDefinitionResponse GetQueueMetricsForSmsDefinition (string definitionKey)

getQueueMetricsForSmsDefinition

Gets metrics for the messages of a SMS definition. Applies to messages that are accepted but not yet processed.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetQueueMetricsForSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the SMS definition

            try
            {
                // getQueueMetricsForSmsDefinition
                GetQueueMetricsForSendDefinitionResponse result = apiInstance.GetQueueMetricsForSmsDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetQueueMetricsForSmsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the SMS definition | 

### Return type

[**GetQueueMetricsForSendDefinitionResponse**](GetQueueMetricsForSendDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmssnotsenttorecipients"></a>
# **GetSMSsNotSentToRecipients**
> GetDefinitionsNotSentToRecipientsResponse GetSMSsNotSentToRecipients (string type, int? pageSize = null, int? lastEventId = null)

getSMSsNotSentToRecipients

Gets a paginated list of messages that were not sent, ordered from oldest to newest.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetSMSsNotSentToRecipientsExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var type = type_example;  // string | Only notSent is supported.
            var pageSize = 56;  // int? | Number of messageKeys (array elements) to return per response page. (optional) 
            var lastEventId = 56;  // int? | Event ID from which you want the response to start. To obtain the initial event ID, submit a request without a lastEventId. The events in the response are listed top to bottom from oldest to newest. (optional) 

            try
            {
                // getSMSsNotSentToRecipients
                GetDefinitionsNotSentToRecipientsResponse result = apiInstance.GetSMSsNotSentToRecipients(type, pageSize, lastEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetSMSsNotSentToRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Only notSent is supported. | 
 **pageSize** | **int?**| Number of messageKeys (array elements) to return per response page. | [optional] 
 **lastEventId** | **int?**| Event ID from which you want the response to start. To obtain the initial event ID, submit a request without a lastEventId. The events in the response are listed top to bottom from oldest to newest. | [optional] 

### Return type

[**GetDefinitionsNotSentToRecipientsResponse**](GetDefinitionsNotSentToRecipientsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmsdefinition"></a>
# **GetSmsDefinition**
> CreateSmsDefinitionRequest GetSmsDefinition (string definitionKey)

getSmsDefinition

Gets SMS definition configuration details for a definition key.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to get

            try
            {
                // getSmsDefinition
                CreateSmsDefinitionRequest result = apiInstance.GetSmsDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetSmsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the definition to get | 

### Return type

[**CreateSmsDefinitionRequest**](CreateSmsDefinitionRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmsdefinitions"></a>
# **GetSmsDefinitions**
> GetSmsDefinitionsResponse GetSmsDefinitions (string filter = null, decimal? pageSize = null, decimal? page = null, string orderBy = null)

getSmsDefinitions

Gets a list of SMS definitions.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetSmsDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var filter = filter_example;  // string | Filter by status type. Accepted values are active, inactive, or deleted. Valid operations are eq and neq. (optional) 
            var pageSize = 8.14;  // decimal? | Number of definitions, which are array elements, to return per paged response. (optional) 
            var page = 8.14;  // decimal? | Page number to return. (optional) 
            var orderBy = orderBy_example;  // string | Sort by a dimension. You can sort by only one dimension. Accepted values are definitionKey, name, createdDate, modifiedDate, and status. (optional) 

            try
            {
                // getSmsDefinitions
                GetSmsDefinitionsResponse result = apiInstance.GetSmsDefinitions(filter, pageSize, page, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetSmsDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Filter by status type. Accepted values are active, inactive, or deleted. Valid operations are eq and neq. | [optional] 
 **pageSize** | **decimal?**| Number of definitions, which are array elements, to return per paged response. | [optional] 
 **page** | **decimal?**| Page number to return. | [optional] 
 **orderBy** | **string**| Sort by a dimension. You can sort by only one dimension. Accepted values are definitionKey, name, createdDate, modifiedDate, and status. | [optional] 

### Return type

[**GetSmsDefinitionsResponse**](GetSmsDefinitionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmssendstatusforrecipient"></a>
# **GetSmsSendStatusForRecipient**
> GetDefinitionSendStatusForRecipientResponse GetSmsSendStatusForRecipient (string messageKey)

getSmsSendStatusForRecipient

Gets the send status for a message. Because this route is rate-limited, use it for infrequent verification of a messageKey. To collect send status at scale, subscribe to transactional send events using the Event Notification Service.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetSmsSendStatusForRecipientExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var messageKey = messageKey_example;  // string | Unique identifier to track message send status. You must provide it in singleton requests using the recipient attribute. To provide message key in batch requests, use the recipients array attribute. If you don’t provide the message key for recipients, it’s generated in the response.

            try
            {
                // getSmsSendStatusForRecipient
                GetDefinitionSendStatusForRecipientResponse result = apiInstance.GetSmsSendStatusForRecipient(messageKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetSmsSendStatusForRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageKey** | **string**| Unique identifier to track message send status. You must provide it in singleton requests using the recipient attribute. To provide message key in batch requests, use the recipients array attribute. If you don’t provide the message key for recipients, it’s generated in the response. | 

### Return type

[**GetDefinitionSendStatusForRecipientResponse**](GetDefinitionSendStatusForRecipientResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="partiallyupdateemaildefinition"></a>
# **PartiallyUpdateEmailDefinition**
> CreateEmailDefinitionRequest PartiallyUpdateEmailDefinition (string definitionKey, UpdateEmailDefinitionRequest body)

partiallyUpdateEmailDefinition

Updates a specific email definition.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class PartiallyUpdateEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition.
            var body = new UpdateEmailDefinitionRequest(); // UpdateEmailDefinitionRequest | JSON Parameters

            try
            {
                // partiallyUpdateEmailDefinition
                CreateEmailDefinitionRequest result = apiInstance.PartiallyUpdateEmailDefinition(definitionKey, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.PartiallyUpdateEmailDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the definition. | 
 **body** | [**UpdateEmailDefinitionRequest**](UpdateEmailDefinitionRequest.md)| JSON Parameters | 

### Return type

[**CreateEmailDefinitionRequest**](CreateEmailDefinitionRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="partiallyupdatesmsdefinition"></a>
# **PartiallyUpdateSmsDefinition**
> CreateSmsDefinitionRequest PartiallyUpdateSmsDefinition (string definitionKey, UpdateSmsDefinitionRequest body)

partiallyUpdateSmsDefinition

Updates a specific SMS definition.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class PartiallyUpdateSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition.
            var body = new UpdateSmsDefinitionRequest(); // UpdateSmsDefinitionRequest | JSON Parameters

            try
            {
                // partiallyUpdateSmsDefinition
                CreateSmsDefinitionRequest result = apiInstance.PartiallyUpdateSmsDefinition(definitionKey, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.PartiallyUpdateSmsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the definition. | 
 **body** | [**UpdateSmsDefinitionRequest**](UpdateSmsDefinitionRequest.md)| JSON Parameters | 

### Return type

[**CreateSmsDefinitionRequest**](CreateSmsDefinitionRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendemailtomultiplerecipients"></a>
# **SendEmailToMultipleRecipients**
> SendDefinitionToMultipleRecipientsResponse SendEmailToMultipleRecipients (SendEmailToMultipleRecipientsRequest body)

sendEmailToMultipleRecipients

Sends a message to multiple recipients using an email definition. You can provide a messageKey in the request; otherwise, the messageKey is automatically generated in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class SendEmailToMultipleRecipientsExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var body = new SendEmailToMultipleRecipientsRequest(); // SendEmailToMultipleRecipientsRequest | JSON Parameters

            try
            {
                // sendEmailToMultipleRecipients
                SendDefinitionToMultipleRecipientsResponse result = apiInstance.SendEmailToMultipleRecipients(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.SendEmailToMultipleRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SendEmailToMultipleRecipientsRequest**](SendEmailToMultipleRecipientsRequest.md)| JSON Parameters | 

### Return type

[**SendDefinitionToMultipleRecipientsResponse**](SendDefinitionToMultipleRecipientsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendemailtosinglerecipient"></a>
# **SendEmailToSingleRecipient**
> SendDefinitionToSingleRecipientResponse SendEmailToSingleRecipient (string messageKey, SendEmailToSingleRecipientRequest body)

sendEmailToSingleRecipient

Sends a message to a single recipient via an email definition using a messageKey path parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class SendEmailToSingleRecipientExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var messageKey = messageKey_example;  // string | Unique identifier used to track message status. Can be automatically created when you create a message or provided as part of the request. Each recipient in a request must have a unique messageKey. If you use a duplicate messageKey in the same send request, the message is rejected.
            var body = new SendEmailToSingleRecipientRequest(); // SendEmailToSingleRecipientRequest | JSON Parameters

            try
            {
                // sendEmailToSingleRecipient
                SendDefinitionToSingleRecipientResponse result = apiInstance.SendEmailToSingleRecipient(messageKey, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.SendEmailToSingleRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageKey** | **string**| Unique identifier used to track message status. Can be automatically created when you create a message or provided as part of the request. Each recipient in a request must have a unique messageKey. If you use a duplicate messageKey in the same send request, the message is rejected. | 
 **body** | [**SendEmailToSingleRecipientRequest**](SendEmailToSingleRecipientRequest.md)| JSON Parameters | 

### Return type

[**SendDefinitionToSingleRecipientResponse**](SendDefinitionToSingleRecipientResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendsmstomultiplerecipients"></a>
# **SendSmsToMultipleRecipients**
> SendDefinitionToMultipleRecipientsResponse SendSmsToMultipleRecipients (SendSmsToMultipleRecipientsRequest body)

sendSmsToMultipleRecipients

Sends a message to multiple recipients using an email definition. You can provide a messageKey in the request; otherwise, the messageKey is automatically generated in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class SendSmsToMultipleRecipientsExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var body = new SendSmsToMultipleRecipientsRequest(); // SendSmsToMultipleRecipientsRequest | JSON Parameters

            try
            {
                // sendSmsToMultipleRecipients
                SendDefinitionToMultipleRecipientsResponse result = apiInstance.SendSmsToMultipleRecipients(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.SendSmsToMultipleRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SendSmsToMultipleRecipientsRequest**](SendSmsToMultipleRecipientsRequest.md)| JSON Parameters | 

### Return type

[**SendDefinitionToMultipleRecipientsResponse**](SendDefinitionToMultipleRecipientsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendsmstosinglerecipient"></a>
# **SendSmsToSingleRecipient**
> SendDefinitionToSingleRecipientResponse SendSmsToSingleRecipient (string messageKey, SendSmsToSingleRecipientRequest body)

sendSmsToSingleRecipient

Sends a message to a single recipient via a SMS definition using a messageKey path parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class SendSmsToSingleRecipientExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var messageKey = messageKey_example;  // string | Unique identifier of the definition used to track message status. The messageKey can be created automatically when you create a message, or you can provide it as part of the request. Each recipient in a request must have a unique messageKey. If you use a duplicate messageKey in the same send request, the message is rejected.
            var body = new SendSmsToSingleRecipientRequest(); // SendSmsToSingleRecipientRequest | JSON Parameters

            try
            {
                // sendSmsToSingleRecipient
                SendDefinitionToSingleRecipientResponse result = apiInstance.SendSmsToSingleRecipient(messageKey, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.SendSmsToSingleRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageKey** | **string**| Unique identifier of the definition used to track message status. The messageKey can be created automatically when you create a message, or you can provide it as part of the request. Each recipient in a request must have a unique messageKey. If you use a duplicate messageKey in the same send request, the message is rejected. | 
 **body** | [**SendSmsToSingleRecipientRequest**](SendSmsToSingleRecipientRequest.md)| JSON Parameters | 

### Return type

[**SendDefinitionToSingleRecipientResponse**](SendDefinitionToSingleRecipientResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

