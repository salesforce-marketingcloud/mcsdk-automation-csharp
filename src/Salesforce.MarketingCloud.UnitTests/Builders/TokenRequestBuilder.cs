using Salesforce.MarketingCloud.Model;

namespace Salesforce.MarketingCloud.UnitTests.Builders
{
    public class TokenRequestBuilder
    {
        private string clientId;
        private string clientSecret;
        private string accountId;
        private string scope;

        private TokenRequestBuilder()
        {
            this.clientId = "clientId";
            this.clientSecret = "clientSecret";
            this.accountId = "accountId";
        }

        public static TokenRequestBuilder ATokenRequest()
        {
            return new TokenRequestBuilder();
        }

        public TokenRequestBuilder WithClientId(string clientId)
        {
            this.clientId = clientId;
            return this;
        }

        public TokenRequestBuilder WithClientSecret(string clientSecret)
        {
            this.clientSecret = clientSecret;
            return this;
        }

        public TokenRequestBuilder WithAccountId(string accountId)
        {
            this.accountId = accountId;
            return this;
        }

        public TokenRequestBuilder WithScope(string scope)
        {
            this.scope = scope;
            return this;
        }

        public TokenRequest Build()
        {
            return new TokenRequest(this.clientId, this.clientSecret, this.accountId, this.scope);
        }
    }
}