using System.Linq;
using NUnit.Framework;
using Salesforce.MarketingCloud.Validation;

namespace Salesforce.MarketingCloud.UnitTests.Validation
{
    [TestFixture]
    public class ModelValidatorTests
    {
        [Test]
        public void TryValidate_SingleInvalidProperty_ReturnsSingleValidationResult()
        {
            var validatableObject = new ValidatableObject { Name = "N", Description = "Description" };
            var modelValidator = new ModelValidator();

            var isModelValid = modelValidator.TryValidate(validatableObject, out var validationResults);

            Assert.IsFalse(isModelValid);
            Assert.AreEqual(1, validationResults.Count);
            var nameValidationResult = validationResults.Single();
            Assert.AreEqual("Invalid value for Name, length must be greater than 2.", nameValidationResult.ErrorMessage);
            CollectionAssert.AreEquivalent(new[] { "Name" }, nameValidationResult.MemberNames);
        }

        [Test]
        public void TryValidate_TwoInvalidProperties_ReturnsMultipleValidationResults()
        {
            var validatableObject = new ValidatableObject { Name = "N", Description = "D" };
            var modelValidator = new ModelValidator();

            var isModelValid = modelValidator.TryValidate(validatableObject, out var validationResults);

            Assert.IsFalse(isModelValid);
            Assert.AreEqual(2, validationResults.Count);

            var nameValidationResult = validationResults.Single(vr => vr.ErrorMessage.Contains("Name"));
            Assert.AreEqual("Invalid value for Name, length must be greater than 2.", nameValidationResult.ErrorMessage);
            CollectionAssert.AreEquivalent(new[] { "Name" }, nameValidationResult.MemberNames);

            var descriptionValidationResult = validationResults.Single(vr => vr.ErrorMessage.Contains("Description"));
            Assert.AreEqual("Invalid value for Description, length must be greater than 3.", descriptionValidationResult.ErrorMessage);
            CollectionAssert.AreEquivalent(new[] { "Description" }, descriptionValidationResult.MemberNames);
        }
    }
}