using Salesforce.MarketingCloud.Client;

namespace Salesforce.MarketingCloud.Exceptions
{
    public class InternalServerErrorException : ApiException
    {
        public InternalServerErrorException(int errorCode, string message, dynamic errorContent = null) : base(errorCode, message)
        {
            this.ErrorContent = errorContent;
        }
    }
}