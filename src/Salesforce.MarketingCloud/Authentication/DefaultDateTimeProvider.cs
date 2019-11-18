using System;

namespace Salesforce.MarketingCloud.Authentication
{
    internal class DefaultDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now => DateTime.Now;
    }
}