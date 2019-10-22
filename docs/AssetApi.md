# Salesforce.MarketingCloud.Api.AssetApi

All URIs are relative to *https://www.exacttargetapis.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAsset**](AssetApi.md#createasset) | **POST** /asset/v1/content/assets | createAsset
[**DeleteAssetById**](AssetApi.md#deleteassetbyid) | **DELETE** /asset/v1/content/assets/{id} | deleteAssetById
[**GetAssetById**](AssetApi.md#getassetbyid) | **GET** /asset/v1/content/assets/{id} | getAssetById
[**PartiallyUpdateAssetById**](AssetApi.md#partiallyupdateassetbyid) | **PATCH** /asset/v1/content/assets/{id} | partiallyUpdateAssetById


<a name="createasset"></a>
# **CreateAsset**
> Asset CreateAsset (Asset body)

createAsset

Creates a new asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class CreateAssetExample
    {
        public void main()
        {
            var apiInstance = new AssetApi();
            var body = new Asset(); // Asset | JSON Parameters

            try
            {
                // createAsset
                Asset result = apiInstance.CreateAsset(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.CreateAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Asset**](Asset.md)| JSON Parameters | 

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteassetbyid"></a>
# **DeleteAssetById**
> void DeleteAssetById (decimal? id)

deleteAssetById

Deletes an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteAssetByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetApi();
            var id = 8.14;  // decimal? | The ID of the asset to delete

            try
            {
                // deleteAssetById
                apiInstance.DeleteAssetById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.DeleteAssetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| The ID of the asset to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassetbyid"></a>
# **GetAssetById**
> Asset GetAssetById (decimal? id)

getAssetById

Gets an asset by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetAssetByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetApi();
            var id = 8.14;  // decimal? | The ID of the asset

            try
            {
                // getAssetById
                Asset result = apiInstance.GetAssetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| The ID of the asset | 

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="partiallyupdateassetbyid"></a>
# **PartiallyUpdateAssetById**
> Asset PartiallyUpdateAssetById (decimal? id, Asset body)

partiallyUpdateAssetById

Updates part of an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class PartiallyUpdateAssetByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetApi();
            var id = 8.14;  // decimal? | The ID of the asset to update
            var body = new Asset(); // Asset | JSON Parameters

            try
            {
                // partiallyUpdateAssetById
                Asset result = apiInstance.PartiallyUpdateAssetById(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.PartiallyUpdateAssetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| The ID of the asset to update | 
 **body** | [**Asset**](Asset.md)| JSON Parameters | 

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

