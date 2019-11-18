using NUnit.Framework;
using Salesforce.MarketingCloud.Client;
using static Salesforce.MarketingCloud.UnitTests.Builders.TokenRequestBuilder;

namespace Salesforce.MarketingCloud.UnitTests
{
    [TestFixture]
    public class TokenRequestTests
    {
        [Test]
        public void Serialized_Payload_Should_Contain_Scope_Property_If_It_Is_Not_Null_Or_Empty()
        {
            var tokenRequest = ATokenRequest().WithScope("permission1 permission2").Build();

            ApiClient apiClient = new ApiClient();
            var serializedPayload = apiClient.Serialize(tokenRequest);

            Assert.True(serializedPayload.Contains("\"scope\":\"permission1 permission2\""));
        }

        [TestCase("", false)]
        [TestCase(null, false)]
        public void Serialized_Payload_Should_Not_Contain_Scope_Property_If_It_Is_Null_Or_Empty(string scope,
            bool expectedContainsScopeProperty)
        {
            var tokenRequest = ATokenRequest().WithScope(scope).Build();

            ApiClient apiClient = new ApiClient();
            var serializedPayload = apiClient.Serialize(tokenRequest);

            var actualContainsScopeProperty = serializedPayload.Contains("\"scope\"");
            Assert.AreEqual(expectedContainsScopeProperty, actualContainsScopeProperty);
        }

        [Test]
        public void Serialized_Payload_Should_Contain_Grant_Type_Property()
        {
            var tokenRequest = ATokenRequest().WithScope("permission1 permission2").Build();

            ApiClient apiClient = new ApiClient();
            var serializedPayload = apiClient.Serialize(tokenRequest);

            Assert.True(serializedPayload.Contains("\"grant_type\":\"client_credentials\""));
        }
    }
}