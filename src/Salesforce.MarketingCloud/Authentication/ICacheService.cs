using Salesforce.MarketingCloud.Model;

namespace Salesforce.MarketingCloud.Authentication
{
    public interface ICacheService
    {
        TokenResponse Get(string key);
        void AddOrUpdate(string key, TokenResponse value);
    }
}