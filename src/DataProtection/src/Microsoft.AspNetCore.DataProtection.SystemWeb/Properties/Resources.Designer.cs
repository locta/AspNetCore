// <auto-generated />
namespace Microsoft.AspNetCore.DataProtection.SystemWeb
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.DataProtection.SystemWeb.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// A call to Protect failed. This most likely means that the data protection system is misconfigured. See the inner exception for more information.
        /// </summary>
        internal static string DataProtector_ProtectFailed
        {
            get => GetString("DataProtector_ProtectFailed");
        }

        /// <summary>
        /// A call to Protect failed. This most likely means that the data protection system is misconfigured. See the inner exception for more information.
        /// </summary>
        internal static string FormatDataProtector_ProtectFailed()
            => GetString("DataProtector_ProtectFailed");

        /// <summary>
        /// The CreateDataProtectionProvider method returned null.
        /// </summary>
        internal static string Startup_CreateProviderReturnedNull
        {
            get => GetString("Startup_CreateProviderReturnedNull");
        }

        /// <summary>
        /// The CreateDataProtectionProvider method returned null.
        /// </summary>
        internal static string FormatStartup_CreateProviderReturnedNull()
            => GetString("Startup_CreateProviderReturnedNull");

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
