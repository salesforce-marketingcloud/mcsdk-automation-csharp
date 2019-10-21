using System;
using System.Collections.Generic;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;
using RestSharp;

namespace Salesforce.MarketingCloud.Authentication
{
    internal class AuthService : IAuthService
    {
        private readonly Configuration configuration;
        private readonly IApiClient apiClient;
        private readonly ICacheService cacheService;

        internal AuthService(Configuration configuration, IApiClient apiClient, ICacheService cacheService)
        {
            this.configuration = configuration;
            this.apiClient = apiClient;
            this.cacheService = cacheService;
        }
        public AuthorizationToken GetAuthorizationToken()
        {
            var cacheKey = GetCacheKey();
            var cachedValue = cacheService.Get(cacheKey);

            if (cachedValue == null)
            {
                apiClient.Configuration = configuration;

                var response = GetTokenResponse();

                SetConfigParameters(response);
                cacheService.AddOrUpdate(cacheKey, response);

                return new AuthorizationToken(response.AccessToken, response.TokenType);
            }
            else
            {
                SetConfigParameters(cachedValue);
                return new AuthorizationToken(cachedValue.AccessToken, cachedValue.TokenType);
            }
        }

        private TokenResponse GetTokenResponse()
        {
            var tokenRequest = new TokenRequest(configuration.ClientId, configuration.ClientSecret, configuration.AccountId, configuration.Scope);

            var serializedTokenRequest = apiClient.Serialize(tokenRequest);

            IRestResponse tokenRestResponse = (IRestResponse) apiClient.CallApi("/v2/token",
                Method.POST,
                new List<KeyValuePair<string, string>>(),
                serializedTokenRequest,
                new Dictionary<string, string>(),
                new Dictionary<string, string>(),
                new Dictionary<string, FileParameter>(),
                new Dictionary<string, string>(),
                "application/json");

            var exceptionFactory = Configuration.DefaultExceptionFactory;
            if (exceptionFactory != null)
            {
                Exception exception = exceptionFactory("GetAuthorizationToken", tokenRestResponse);
                if (exception != null) throw exception;
            }

            var response =
                (TokenResponse) configuration.ApiClient.Deserialize(tokenRestResponse,
                    typeof(TokenResponse));
            return response;
        }

        private void SetConfigParameters(TokenResponse response)
        {
            configuration.RestInstanceUrl = response.RestInstanceUrl;
            configuration.SoapInstanceUrl = response.SoapInstanceUrl;
            configuration.BasePath = response.RestInstanceUrl;
        }

        private string GetCacheKey()
        {
            return configuration.ClientId + "-" + configuration.AccountId;
        }
    }
}