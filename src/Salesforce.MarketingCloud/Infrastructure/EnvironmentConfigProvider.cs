using System;
using Salesforce.MarketingCloud.Exceptions;

namespace Salesforce.MarketingCloud
{
    internal class EnvironmentConfigProvider
    {
        public string Get(string variable, bool mandatory = true)
        {
            var envVariableValue = Environment.GetEnvironmentVariable(variable);

            if (envVariableValue != null) return envVariableValue;

            if (mandatory)
            {
                throw new EnvironmentVariableNotSetException(variable);
            }

            return null;
        }
    }
}