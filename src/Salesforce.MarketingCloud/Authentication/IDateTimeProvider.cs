using System;

namespace Salesforce.MarketingCloud.Authentication
{
    internal interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}