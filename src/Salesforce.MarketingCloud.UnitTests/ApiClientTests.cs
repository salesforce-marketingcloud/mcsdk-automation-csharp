using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using NSubstitute;
using NUnit.Framework;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.UnitTests.Validation;
using Salesforce.MarketingCloud.Validation;

namespace Salesforce.MarketingCloud.UnitTests
{
    [TestFixture]
    public class ApiClientTests
    {
        [Test]
        public void Serialize_WhenModelIsValid_ReturnsSerializedModel()
        {
            var validatableObject = new ValidatableObject {Name = "Name", Description = "Description"};
            ApiClient apiClient = new ApiClient();

            var serializedModel = apiClient.Serialize(validatableObject);

            Assert.AreEqual("{\"Name\":\"Name\",\"Description\":\"Description\"}", serializedModel);
        }

        [Test]
        public void Serialize_WhenModelIsInvalid_ThrowsModelValidationException()
        {
            var validatableObject = new ValidatableObject { Name = "N", Description = "D" };
            ApiClient apiClient = new ApiClient();

            try
            {
                apiClient.Serialize(validatableObject);
            }
            catch (ModelValidationException e)
            {
                Assert.AreEqual("ValidatableObject", e.ModelType);

                var validationResults = e.ValidationResults;
                Assert.AreEqual(2, validationResults.Count);

                var nameValidationResult = validationResults.Single(vr => vr.ErrorMessage.Contains("Name"));
                Assert.AreEqual("Invalid value for Name, length must be greater than 2.", nameValidationResult.ErrorMessage);
                CollectionAssert.AreEquivalent(new[] { "Name" }, nameValidationResult.MemberNames);

                var descriptionValidationResult = validationResults.Single(vr => vr.ErrorMessage.Contains("Description"));
                Assert.AreEqual("Invalid value for Description, length must be greater than 3.", descriptionValidationResult.ErrorMessage);
                CollectionAssert.AreEquivalent(new[] { "Description" }, descriptionValidationResult.MemberNames);

                return;
            }

            Assert.Fail("ModelValidationException was not thrown");
        }
    }
}