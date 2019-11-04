using System;
using Newtonsoft.Json.Linq;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Model;

namespace Salesforce.MarketingCloud.Samples
{
    public class SampleHelper
    {
        public static Asset CreateEmailAsset()
        {
            string customerKey = $"{Guid.NewGuid()}";    // it has be unique
            string assetName = $"{Guid.NewGuid()}";      // it has be unique
            const string assetDescription = "EmailAsset created from automated C# SDK";

            const int htmlEmailAssetTypeId = 208;
            const string assetTypeName = "htmlemail";
            var assetType = new AssetType(htmlEmailAssetTypeId, assetTypeName);

            const string json = @"{
                subjectline: {
                    content : 'Email sent from the C# SDK'
                },
                html: {
                    content: '<!DOCTYPE html>
                              <html lang=""en"">
                              <head>
                                  <meta charset=""UTF-8"">
                                  <title>Welcome to SFMC Transactional Messaging</title>
                              </head>
                              <body>
                                  <img src=""https://image.slidesharecdn.com/scalingdevelopereffortswithsalesforcemarketingcloudpptxv4-180803183610/95/scaling-developer-efforts-with-salesforce-marketing-cloud-31-638.jpg?cb=1533321419""
                                        alt=""Let\'s Talk TM image"">
                              </body>
                              </html>'
                }
            }";

            JObject views = JObject.Parse(json);

           return new Asset(customerKey: customerKey, assetType: assetType, name: assetName, description: assetDescription, views: views);
        }

        public static CreateEmailDefinitionRequest CreateEmailDefinitionObject(AssetApi assetApi)
        {
            /* Replace '<SUBSCRIBERS LIST KEY>' with the key of
            one of your subscribers lists or use 'All Subscribers'*/
            const string subscribersListKey = "<SUBSCRIBERS LIST KEY>";

            var emailAsset = CreateEmailAsset();
            var createAssetResult = assetApi.CreateAsset(emailAsset);
            var customerKey = createAssetResult.CustomerKey;
            var emailDefinitionName = $"{Guid.NewGuid()}";
            var emailDefinitionKey = $"{Guid.NewGuid()}";
            var content = new CreateEmailDefinitionContent(customerKey);
            var subscriptions = new CreateEmailDefinitionSubscriptions(subscribersListKey);

            return new CreateEmailDefinitionRequest(emailDefinitionName, emailDefinitionKey, content: content, subscriptions: subscriptions);
        }
    }
}