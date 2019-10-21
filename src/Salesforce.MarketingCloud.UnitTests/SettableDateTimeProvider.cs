using System;
using Salesforce.MarketingCloud.Authentication;

namespace Salesforce.MarketingCloud.UnitTests
{
    public class SettableDateTimeProvider : IDateTimeProvider
    {
        public SettableDateTimeProvider(DateTime dateTime)
        {
            this.Now = dateTime;
        }

        public DateTime Now { get; set; }
    }
}