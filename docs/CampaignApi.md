# Salesforce.MarketingCloud.Api.CampaignApi

All URIs are relative to *https://www.exacttargetapis.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCampaign**](CampaignApi.md#createcampaign) | **POST** /hub/v1/campaigns | createCampaign
[**DeleteCampaignById**](CampaignApi.md#deletecampaignbyid) | **DELETE** /hub/v1/campaigns/{id} | deleteCampaignById
[**GetAllCampaigns**](CampaignApi.md#getallcampaigns) | **GET** /hub/v1/campaigns | getAllCampaigns
[**GetCampaignById**](CampaignApi.md#getcampaignbyid) | **GET** /hub/v1/campaigns/{id} | getCampaignById


<a name="createcampaign"></a>
# **CreateCampaign**
> Campaign CreateCampaign (Campaign body)

createCampaign

Creates a campaign.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class CreateCampaignExample
    {
        public void main()
        {
            var apiInstance = new CampaignApi();
            var body = new Campaign(); // Campaign | JSON Parameters

            try
            {
                // createCampaign
                Campaign result = apiInstance.CreateCampaign(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.CreateCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Campaign**](Campaign.md)| JSON Parameters | 

### Return type

[**Campaign**](Campaign.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecampaignbyid"></a>
# **DeleteCampaignById**
> void DeleteCampaignById (string id)

deleteCampaignById

Deletes a campaign.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteCampaignByIdExample
    {
        public void main()
        {
            var apiInstance = new CampaignApi();
            var id = id_example;  // string | The ID of the campaign to delete

            try
            {
                // deleteCampaignById
                apiInstance.DeleteCampaignById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.DeleteCampaignById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the campaign to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcampaigns"></a>
# **GetAllCampaigns**
> GetAllCampaignsResponse GetAllCampaigns ()

getAllCampaigns

Gets all campaigns.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetAllCampaignsExample
    {
        public void main()
        {
            var apiInstance = new CampaignApi();

            try
            {
                // getAllCampaigns
                GetAllCampaignsResponse result = apiInstance.GetAllCampaigns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.GetAllCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetAllCampaignsResponse**](GetAllCampaignsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaignbyid"></a>
# **GetCampaignById**
> Campaign GetCampaignById (string id)

getCampaignById

Retrieves a campaign.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetCampaignByIdExample
    {
        public void main()
        {
            var apiInstance = new CampaignApi();
            var id = id_example;  // string | Campaign ID

            try
            {
                // getCampaignById
                Campaign result = apiInstance.GetCampaignById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.GetCampaignById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Campaign ID | 

### Return type

[**Campaign**](Campaign.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

