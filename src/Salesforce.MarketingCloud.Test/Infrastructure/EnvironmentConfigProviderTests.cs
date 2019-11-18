using System;
using NUnit.Framework;
using Salesforce.MarketingCloud.Exceptions;

namespace Salesforce.MarketingCloud.Test.Infrastructure
{
    [TestFixture]
    public class EnvironmentConfigProviderTests
    {
        private readonly EnvironmentConfigProvider environmentConfigProvider = new EnvironmentConfigProvider();

        [Test]
        public void Should_Throw_EnvironmentVariableNotSetException_When_Trying_To_Get_A_Mandatory_Env_Variable_That_Is_Not_Set()
        {
            var exception = Assert.Throws<EnvironmentVariableNotSetException>(
                () => environmentConfigProvider.Get("NON_EXISTING_VAR_KEY", true));
            Assert.AreEqual("Env variable NON_EXISTING_VAR_KEY is not set", exception.Message);
        }

        [Test]
        public void Should_Return_Null_When_Trying_To_Get_An_Optional_Env_Variable_That_Is_Not_Set()
        {
            var envVariableValue = environmentConfigProvider.Get("NON_EXISTING_VAR_KEY", false);
            Assert.Null(envVariableValue);
        }

        [Test]
        public void Should_Return_Env_Variable_Value()
        {
            Environment.SetEnvironmentVariable("SOME_VARIABLE", "test");

            var envVariableValue = environmentConfigProvider.Get("SOME_VARIABLE");
            Assert.AreEqual("test", envVariableValue);

            Environment.SetEnvironmentVariable("SOME_VARIABLE", null);
        }
    }
}