using System;
using System.Collections.Generic;
using Salesforce.MarketingCloud;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Model;

namespace Samples
{
    partial class Sample
    {
        static void SendEmailToMultipleRecipients()
        {
            // Replace '<CONTACT1 KEY>' and '<CONTACT2 KEY>' with real subscriber keys
            const string contact1Key = "<CONTACT1 KEY>";
            const string contact2Key = "<CONTACT2 KEY>";

            // Environment variables instantiated client:
            var client = new Client();

            // Get the asset, transactional messaging API instances:
            var assetApi = client.AssetApi;
            var transactionalMessagingApi = client.TransactionalMessagingApi;

            // Create email send definition:
            var emailDefinitionObject = SampleHelper.CreateEmailDefinitionObject(assetApi);
            var createEmailDefinitionResult = transactionalMessagingApi.CreateEmailDefinition(emailDefinitionObject);

            // Send email to multiple recipients:
            var recipient1MessageKey = $"{Guid.NewGuid()}";
            var recipient2MessageKey = $"{Guid.NewGuid()}";

            var recipient1 = new Recipient(contact1Key, messageKey: recipient1MessageKey);
            var recipient2 = new Recipient(contact2Key, messageKey: recipient2MessageKey);

            var recipientsList = new List<Recipient>() {recipient1, recipient2};

            var batchMessageRequestBody = new SendEmailToMultipleRecipientsRequest(createEmailDefinitionResult.DefinitionKey, recipientsList);

            transactionalMessagingApi.SendEmailToMultipleRecipients(batchMessageRequestBody);

            // Get the send status of the two email sends:
            var recipient1SendStatus = transactionalMessagingApi.GetEmailSendStatusForRecipient(recipient1MessageKey);
            var recipient2SendStatus = transactionalMessagingApi.GetEmailSendStatusForRecipient(recipient2MessageKey);
        }
    }
}
