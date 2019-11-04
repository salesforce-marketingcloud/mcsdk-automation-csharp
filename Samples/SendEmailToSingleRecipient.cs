using System;
using System.Collections.Generic;
using Salesforce.MarketingCloud;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Model;

namespace Samples
{
    partial class Sample
    {
        static void SendEmailToSingleRecipient()
        {
            // Replace '<CONTACT KEY>' with a real subscriber key
            const string contactKey = "<CONTACT KEY>";

            /* Replace the constructor parameters with your Marketing Cloud account credentials
            (<APPLICATION DATA-ACCESS PERMISSIONS> is not a mandatory parameter) */

            var client = new Client(
                "<AUTH BASE URL>",
                "<CLIENT ID>",
                "<CLIENT SECRET>",
                "<ACCOUNT ID>",
                "<APPLICATION DATA-ACCESS PERMISSIONS>");

            // Get the asset, transactional messaging API instances:
            var assetApi = client.AssetApi;
            var transactionalMessagingApi = client.TransactionalMessagingApi;

            // Create email send definition:
            var emailDefinitionObject = SampleHelper.CreateEmailDefinitionObject(assetApi);
            var createEmailDefinitionResult = transactionalMessagingApi.CreateEmailDefinition(emailDefinitionObject);

            // Get email send definition:
            var getEmailDefinitionsResult = transactionalMessagingApi.GetEmailDefinition(createEmailDefinitionResult.DefinitionKey);

            // Update email send definition:
            var updatedDefinitionDescription = new UpdateEmailDefinitionRequest(description: "Updated email definition description");
            var partiallyUpdateEmailDefinitionResult = transactionalMessagingApi.PartiallyUpdateEmailDefinition(getEmailDefinitionsResult.DefinitionKey, updatedDefinitionDescription);

            // Get email send definition:
            getEmailDefinitionsResult = transactionalMessagingApi.GetEmailDefinition(partiallyUpdateEmailDefinitionResult.DefinitionKey);

            // Send email to single recipient:
            var recipientMessageKey = $"{Guid.NewGuid()}";
            var recipient = new Recipient(contactKey);

            var messageRequestBody = new SendEmailToSingleRecipientRequest(getEmailDefinitionsResult.DefinitionKey, recipient);
            transactionalMessagingApi.SendEmailToSingleRecipient(recipientMessageKey, messageRequestBody);

            // Get the send status of the email send:
            var recipientSendStatus = transactionalMessagingApi.GetEmailSendStatusForRecipient(recipientMessageKey);
        }
    }
}
