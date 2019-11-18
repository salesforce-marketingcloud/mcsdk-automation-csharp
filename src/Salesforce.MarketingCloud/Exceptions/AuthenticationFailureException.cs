using Salesforce.MarketingCloud.Client;

namespace Salesforce.MarketingCloud.Exceptions
{
    public class AuthenticationFailureException : ApiException
    {
        public AuthenticationFailureException(int errorCode, string message, dynamic errorContent = null) : base(errorCode, message)
        {
            this.ErrorContent = errorContent;
        }
    }
}