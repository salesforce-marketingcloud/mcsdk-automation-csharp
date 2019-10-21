using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Salesforce.MarketingCloud.Authentication;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;
using NSubstitute;
using NUnit.Framework;
using RestSharp;
using Salesforce.MarketingCloud.Exceptions;

namespace Salesforce.MarketingCloud.UnitTests
{
    [TestFixture]
    public class AuthServiceTests
    {
        [Test]
        public void GetAuthorizationToken_WhenCacheIsNotExpired_CallsOneTimeCallApiMethod()
        {
            var configurationStub = new Configuration();
            var authRequestResponse = CreateAuthRequestResponse();
            var apiClientMock = CreateApiClient(authRequestResponse);
            var currentTime = new DateTime(2000, 1, 1);
            var dateTimeProvider = new SettableDateTimeProvider(currentTime);
            var cacheServiceStub1 = new CacheService(dateTimeProvider);
            var cacheServiceStub2 = new CacheService(dateTimeProvider);

            var authServiceInstance1 = new AuthService(configurationStub, apiClientMock, cacheServiceStub1);
            authServiceInstance1.GetAuthorizationToken();
            var authServiceInstance2 = new AuthService(configurationStub, apiClientMock, cacheServiceStub2);
            authServiceInstance2.GetAuthorizationToken();

            apiClientMock.Received(1).CallApi(Arg.Any<string>(),
                Arg.Any<Method>(),
                Arg.Any<List<KeyValuePair<string, string>>>(),
                Arg.Any<object>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<Dictionary<string, FileParameter>>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<string>());
        }

        [Test]
        public void GetAuthorizationToken_WhenCacheIsExpired_CallsTwoTimesCallApiMethod()
        {
            var configurationStub = new Configuration();
            var authRequestResponse = CreateAuthRequestResponse();
            var apiClientMock = CreateApiClient(authRequestResponse);
            var currentTime = new DateTime(2000, 1, 1);
            var dateTimeProvider = new SettableDateTimeProvider(currentTime);
            var cacheServiceStub = new CacheService(dateTimeProvider);

            var authService = new AuthService(configurationStub, apiClientMock, cacheServiceStub);
            authService.GetAuthorizationToken();

            DateTime newCurrentTime = currentTime.AddMinutes(20);
            dateTimeProvider.Now = newCurrentTime;

            authService.GetAuthorizationToken();

            apiClientMock.Received(2).CallApi(Arg.Any<string>(),
                Arg.Any<Method>(),
                Arg.Any<List<KeyValuePair<string, string>>>(),
                Arg.Any<object>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<Dictionary<string, FileParameter>>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<string>());
        }

        [Test]
        public void GetAuthorizationToken_WhenValueIsNotPresentInCache_CallsTokenApi()
        {
            var configurationStub = new Configuration();
            var cacheServiceStub = Substitute.For<ICacheService>();
            var apiClientMock = Substitute.For<IApiClient>();
            var response = CreateAuthRequestResponse(HttpStatusCode.OK);
          
            apiClientMock.CallApi(
            Arg.Any<string>(),
                Arg.Any<Method>(),
                Arg.Any<List<KeyValuePair<string, string>>>(),
                Arg.Any<object>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<Dictionary<string, FileParameter>>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<string>()
            ).Returns(response);

            var authService = new AuthService(configurationStub, apiClientMock, cacheServiceStub);

            authService.GetAuthorizationToken();

            apiClientMock.Received().CallApi(
                Arg.Is("/v2/token"),
                Arg.Any<Method>(),
                Arg.Any<List<KeyValuePair<string, string>>>(),
                Arg.Any<object>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<Dictionary<string, FileParameter>>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<string>()
                );
        }

        [Test]
        public void GetAuthorizationToken_WhenTokenApiCallsFails_ThrowsException()
        {
            var configurationStub = new Configuration();
            var cacheServiceStub = Substitute.For<ICacheService>();
            var apiClientMock = Substitute.For<IApiClient>();
            var response = CreateUnauthorizedAuthRequestResponse();

            apiClientMock.CallApi(
                Arg.Any<string>(),
                Arg.Any<Method>(),
                Arg.Any<List<KeyValuePair<string, string>>>(),
                Arg.Any<object>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<Dictionary<string, FileParameter>>(),
                Arg.Any<Dictionary<string, string>>(),
                Arg.Any<string>()
            ).Returns(response);

            var authService = new AuthService(configurationStub, apiClientMock, cacheServiceStub);

            Assert.Throws<AuthenticationFailureException>(() => authService.GetAuthorizationToken());
        }

        [Test]
        public void GetAuthorizationToken_WhenValueIsPresentInCache_SetsConfigurationValues()
        {
            var apiClientStub = Substitute.For<IApiClient>();
            var cacheServiceStub = CreateCacheService();
            var configurationStub = new Configuration();

            var authService = new AuthService(configurationStub, apiClientStub, cacheServiceStub);

            authService.GetAuthorizationToken();

            Assert.AreEqual("https://rest.com", configurationStub.RestInstanceUrl);
            Assert.AreEqual("https://soap.com", configurationStub.SoapInstanceUrl);
            Assert.AreEqual("https://rest.com", configurationStub.BasePath);
        }

        [Test]
        public void GetAuthorizationToken_WhenValueIsNotPresentInCache_SetsConfigurationValues()
        {
            var authRequestResponse = CreateAuthRequestResponse();
            var apiClientMock = CreateApiClient(authRequestResponse);
            var configurationStub = new Configuration();
            ICacheService cacheServiceMock = Substitute.For<ICacheService>();

            var authService = new AuthService(configurationStub, apiClientMock, cacheServiceMock);

            authService.GetAuthorizationToken();

            Assert.AreEqual("https://rest.com", configurationStub.RestInstanceUrl);
            Assert.AreEqual("https://rest.com", configurationStub.BasePath);
            Assert.AreEqual("https://soap.com", configurationStub.SoapInstanceUrl);
        }

        [Test]
        public void GetAuthorizationToken_WhenValueIsNotPresentInCache_CallsAddOrUpdate()
        {
            var authRequestResponse = CreateAuthRequestResponse();
            var apiClientStub = CreateApiClient(authRequestResponse);
            var configurationStub = new Configuration();
            var cacheServiceMock = Substitute.For<ICacheService>();

            var authService = new AuthService(configurationStub, apiClientStub, cacheServiceMock);

            authService.GetAuthorizationToken();

            cacheServiceMock.Received().AddOrUpdate(Arg.Any<string>(), Arg.Any<TokenResponse>());
        }

        [Test]
        public void GetAuthorizationToken_WhenValueIsNotPresentInCache_ReturnsAuthorizationTokenFromApiResponse()
        {
            var authRequestResponse = CreateAuthRequestResponse();
            var apiClientStub = CreateApiClient(authRequestResponse);
            var configurationStub = new Configuration();
            var cacheServiceStub = Substitute.For<ICacheService>();

            var authService = new AuthService(configurationStub, apiClientStub, cacheServiceStub);

            var response = authService.GetAuthorizationToken();

            Assert.AreEqual(response.Value, "access_token");
            Assert.AreEqual(response.Type, "token_type");
        }

        [Test]
        public void GetAuthorizationToken_WhenAuthenticationFails_ThrowsException()
        {
            var authRequestResponse = CreateUnauthorizedAuthRequestResponse();
            var apiClientStub = CreateApiClient(authRequestResponse);
            var configurationStub = new Configuration();
            var cacheServiceStub = Substitute.For<ICacheService>();

            var authService = new AuthService(configurationStub, apiClientStub, cacheServiceStub);

            Assert.Throws<AuthenticationFailureException>(() => authService.GetAuthorizationToken());
        }

        [Test]
        public void GetAuthorizationToken_WhenValueIsPresentInCache_ReturnsAuthorizationTokenFromCache()
        {
            var authRequestResponse = CreateAuthRequestResponse();
            var apiClientStub = CreateApiClient(authRequestResponse);
            var configurationStub = new Configuration();
            var cacheServiceStub = CreateCacheService();

            var authService = new AuthService(configurationStub, apiClientStub, cacheServiceStub);

            var response = authService.GetAuthorizationToken();

            Assert.AreEqual(response.Value, "access_token");
            Assert.AreEqual(response.Type, "token_type");
        }

        [TearDown]
        public void CleanUp()
        {
            CacheService.cache = new ConcurrentDictionary<string, Tuple<TokenResponse, DateTime>>();
        }

        private ICacheService CreateCacheService()
        {
            ICacheService cacheService = Substitute.For<ICacheService>();

            cacheService.Get(Arg.Any<string>()).Returns(new TokenResponse()
            {
                AccessToken = "access_token",
                TokenType = "token_type",
                RestInstanceUrl = "https://rest.com",
                SoapInstanceUrl = "https://soap.com",
                ExpiresIn = 1000
            });

            return cacheService;
        }

        private IRestResponse CreateAuthRequestResponse(HttpStatusCode httpStatusCode = HttpStatusCode.OK)
        {
            IRestResponse authRequestResponse = Substitute.For<IRestResponse>();
            authRequestResponse.Content.Returns(@"{ 
                'access_token': 'access_token', 
                'token_type': 'token_type',
                'expires_in': 1000,
                'rest_instance_url':'https://rest.com',
                'soap_instance_url':'https://soap.com'
            }");

            authRequestResponse.StatusCode.Returns(httpStatusCode);
            return authRequestResponse;
        }

        private IRestResponse CreateUnauthorizedAuthRequestResponse()
        {
            IRestResponse authRequestResponse = Substitute.For<IRestResponse>();
            authRequestResponse.Content.Returns(@"{ 
                'error': 'invalid client', 
                'error_description': 'Invalid client ID. Use the client ID in Marketing Cloud Installed Packages.',
                'error_uri': 'https://developer.salesforce.com/docs'
            }");

            authRequestResponse.StatusCode.Returns(HttpStatusCode.Unauthorized);
            return authRequestResponse;
        }

        private IApiClient CreateApiClient(IRestResponse authRequestResponse)
        {
            IApiClient apiClient = Substitute.For<IApiClient>();
            apiClient
                .CallApi(
                    Arg.Any<string>(),
                    Arg.Any<Method>(),
                    Arg.Any<List<KeyValuePair<string, string>>>(),
                    Arg.Any<object>(),
                    Arg.Any<Dictionary<string, string>>(),
                    Arg.Any<Dictionary<string, string>>(),
                    Arg.Any<Dictionary<string, FileParameter>>(),
                    Arg.Any<Dictionary<string, string>>(),
                    Arg.Any<string>()
                ).Returns(authRequestResponse);
            return apiClient;
        }
    }
}