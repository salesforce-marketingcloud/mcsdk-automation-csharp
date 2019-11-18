using System.Linq;
using Salesforce.MarketingCloud.Authentication;
using NSubstitute;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using OAuth2Authenticator = Salesforce.MarketingCloud.Authentication.OAuth2Authenticator;

namespace Salesforce.MarketingCloud.UnitTests
{
    [TestFixture]
    public class OAuth2AuthenticatorTests
    {
        [Test]
        public void Authenticate_WhenAuthenticationSucceeds_SetsAuthenticationHeader()
        {
            IAuthService authServiceStub = Substitute.For<IAuthService>();
            authServiceStub.GetAuthorizationToken()
                .Returns(new AuthorizationToken("access_token", "token_type"));

            IAuthenticator oAuth2Authenticator =
                new OAuth2Authenticator(authServiceStub);

            IRestClient restClient = new RestClient("https://auth.com");
            IRestRequest request = new RestRequest();
            oAuth2Authenticator.Authenticate(restClient, request);

            var authorizationHeader =
                request.Parameters.First(p => p.Type == ParameterType.HttpHeader && p.Name == "Authorization");

            Assert.AreEqual("token_type access_token", authorizationHeader.Value);
        }
    }
}
