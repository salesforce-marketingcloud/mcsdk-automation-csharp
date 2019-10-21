using System.Reflection;
using System.Runtime.Versioning;

namespace Salesforce.MarketingCloud.Client
{
    public static class RuntimeInformationProvider
    {
        static RuntimeInformationProvider()
        {
            try
            {
                var framework = Assembly
                    .GetEntryAssembly()?
                    .GetCustomAttribute<TargetFrameworkAttribute>()?
                    .FrameworkName ?? string.Empty;
                var osDescription = System.Runtime.InteropServices.RuntimeInformation.OSDescription;

                ClientEnvironmentRuntimeInformation = $"{framework}/{osDescription}";
            }
            catch
            {
                ClientEnvironmentRuntimeInformation = "NA/NA";
            }
        }

        public static string ClientEnvironmentRuntimeInformation { get; }
    }
}