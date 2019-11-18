using System;
using System.Reflection;
using Castle.Core.Internal;
using NUnit.Framework;
using Salesforce.MarketingCloud.Client;

namespace Salesforce.MarketingCloud.UnitTests
{
    [TestFixture]
    public class ConfigurationTests
    {
        [Test]
        public void UserAgent_Should_Match_Expected_Format()
        {
            Configuration configuration = new Configuration();
            var userAgentParts = configuration.UserAgent.Split("/");

            Assert.AreEqual(5, userAgentParts.Length);
            var sdkName = userAgentParts[0];
            var languageName = userAgentParts[1];
            var assemblyVersion = typeof(Configuration).Assembly.GetName().Version;
            // get only the major, minor and build version number
            var expectedAssemblyVersion = $"{assemblyVersion.Major}.{assemblyVersion.Minor}.{assemblyVersion.Build}";
            var sdkVersion = userAgentParts[2];
            var targetFrameworkName = userAgentParts[3];
            var osDescription = userAgentParts[4];

            Assert.AreEqual("MCSDK", sdkName);
            Assert.AreEqual("CSHARP", languageName);
            Assert.AreEqual(expectedAssemblyVersion, sdkVersion);
            Assert.False(targetFrameworkName.IsNullOrEmpty());
            Assert.False(osDescription.IsNullOrEmpty());
        }
    }
}