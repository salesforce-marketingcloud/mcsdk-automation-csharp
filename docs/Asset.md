# Salesforce.MarketingCloud.Model.Asset
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **decimal?** | The id of the asset | [optional] 
**CustomerKey** | **string** | Reference to customer&#39;s private ID/name for the asset | 
**ContentType** | **string** | The type that the content attribute will be in | [optional] 
**Data** | **Object** | Property bag containing the asset data | [optional] 
**AssetType** | [**AssetType**](AssetType.md) |  | 
**Version** | **decimal?** | The version of the asset | [optional] 
**Locked** | **bool?** | Specifies if the asset can be modified or not | [optional] 
**FileProperties** | **Object** | Stores the different properties that this asset refers to if it is a file type | [optional] 
**Name** | **string** | Name of the asset, set by the client | 
**Description** | **string** | Description of the asset, set by the client | 
**Category** | **Object** | ID of the category the asset belongs to | [optional] 
**Tags** | **List&lt;string&gt;** | List of tags associated with the asset | [optional] 
**Content** | **string** | The actual content of the asset | [optional] 
**Design** | **string** | Fallback for display when neither content nor supercontent are provided | [optional] 
**SuperContent** | **string** | Content that supersedes content in terms of display | [optional] 
**CustomFields** | **Object** | Custom fields within an asset | [optional] 
**Views** | **Object** | Views within an asset | [optional] 
**Blocks** | **Object** | Blocks within the asset | [optional] 
**MinBlocks** | **decimal?** | Minimum number of blocks within an asset | [optional] 
**MaxBlocks** | **decimal?** | Maximum number of blocks within an asset | [optional] 
**Channels** | **Object** | List of channels that are allowed to use this asset | [optional] 
**AllowedBlocks** | **List&lt;string&gt;** | List of blocks that are allowed in the asset | [optional] 
**Slots** | **Object** | Slots within the asset | [optional] 
**BusinessUnitAvailability** | **Object** | A dictionary of member IDs that have been granted access to the asset | [optional] 
**SharingProperties** | [**SharingProperties**](SharingProperties.md) |  | [optional] 
**Template** | **Object** | Template the asset follows | [optional] 
**File** | **string** | Base64-encoded string of a file associated with an asset | [optional] 
**GenerateFrom** | **string** | Tells the sending compiler what view to use for generating this view&#39;s content | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

