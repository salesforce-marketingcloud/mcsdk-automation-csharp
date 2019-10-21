using Salesforce.MarketingCloud.Infrastructure;

namespace Salesforce.MarketingCloud.Test
{
    public static class ClientFactory
    {
        private static string authBasePath;
        private static string clientId;
        private static string clientSecret;
        private static string accountId;
        private static string scope;

        static ClientFactory()
        {
            var configProvider = new EnvironmentConfigProvider();

            authBasePath = configProvider.Get(EnvVariableName.AUTH_BASE_URL);
            clientId = configProvider.Get(EnvVariableName.CLIENT_ID);
            clientSecret = configProvider.Get(EnvVariableName.CLIENT_SECRET);
            accountId = configProvider.Get(EnvVariableName.ACCOUNT_ID);
            scope = configProvider.Get(EnvVariableName.SCOPE, false);
        }

        internal static Api.Client Create()
        {
            return new Api.Client(authBasePath, clientId, clientSecret, accountId, scope);
        }
    }
}