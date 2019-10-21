using System;
using NUnit.Framework;
using Salesforce.MarketingCloud.Exceptions;
using Salesforce.MarketingCloud.Infrastructure;

namespace Salesforce.MarketingCloud.Test
{
    [TestFixture]
    public class ClientTests
    {
        [TestCase(EnvVariableName.AUTH_BASE_URL)]
        [TestCase(EnvVariableName.CLIENT_ID)]
        [TestCase(EnvVariableName.CLIENT_SECRET)]
        [TestCase(EnvVariableName.ACCOUNT_ID)]
        public void Parameterless_Constructor_Should_Throw_EnvironmentVariableNotSetException_If_Env_Variable_Is_Not_Set(string variable)
        {
            var oldValue = Environment.GetEnvironmentVariable(variable);
            try
            {
                Environment.SetEnvironmentVariable(variable, null);
                var exception = Assert.Throws<EnvironmentVariableNotSetException>(() => { new Api.Client(); });
                Assert.AreEqual($"Env variable {variable} is not set", exception.Message);
                Assert.AreEqual(variable, exception.Variable);
            }
            finally
            {
                Environment.SetEnvironmentVariable(variable, oldValue);
            }
        }

        [TestCase(EnvVariableName.SCOPE)]
        public void Parameterless_Constructor_Should_Not_Throw_If_Optional_Env_Variable_Is_Not_Set(string variable)
        {
            var oldValue = Environment.GetEnvironmentVariable(variable);
            try
            {
                Environment.SetEnvironmentVariable(variable, null);
                Assert.DoesNotThrow(() => { new Api.Client(); });
            }
            finally
            {
                Environment.SetEnvironmentVariable(variable, oldValue);
            }
        }
    }
}