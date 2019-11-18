using System;
using Salesforce.MarketingCloud.Authentication;
using Salesforce.MarketingCloud.Client;

namespace Salesforce.MarketingCloud.Api
{
    public class BaseApi
    {
        private Salesforce.MarketingCloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetApi"/> class.
        /// </summary>
        /// <returns></returns>
        internal BaseApi(string authBaseUrl, string clientId, string clientSecret, string accountId, string scope)
        {
            if (string.IsNullOrWhiteSpace(authBaseUrl))
            {
                throw new ArgumentException($"{nameof(authBaseUrl)} cannot not be null, empty or whitespace");
            }
            if (string.IsNullOrWhiteSpace(clientId))
            {
                throw new ArgumentException($"{nameof(clientId)} cannot not be null, empty or whitespace");
            }
            if (string.IsNullOrWhiteSpace(clientSecret))
            {
                throw new ArgumentException($"{nameof(clientSecret)} cannot not be null, empty or whitespace");
            }
            if (string.IsNullOrWhiteSpace(accountId))
            {
                throw new ArgumentException($"{nameof(accountId)} cannot not be null, empty or whitespace");
            }

            this.Configuration = new Salesforce.MarketingCloud.Client.Configuration
            {
                AuthenticationInstanceUrl = authBaseUrl,
                ClientId = clientId,
                ClientSecret = clientSecret,
                AccountId = accountId,
                Scope = scope
            };

            var defaultDateTimeProvider = new DefaultDateTimeProvider();
            var cacheService = new CacheService(defaultDateTimeProvider);
            var apiClient = new ApiClient(authBaseUrl);
            var authService = new AuthService(this.Configuration, apiClient, cacheService);

            this.Configuration.ApiClient.RestClient.Authenticator =
                new Salesforce.MarketingCloud.Authentication.OAuth2Authenticator(authService);

            ExceptionFactory = Salesforce.MarketingCloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        internal Salesforce.MarketingCloud.Client.Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        internal Salesforce.MarketingCloud.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }
    }
}