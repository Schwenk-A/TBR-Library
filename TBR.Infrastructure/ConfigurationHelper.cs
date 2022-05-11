using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace TBR.Infrastructure
{
    public class ConfigurationHelper
    {       
        private const string AppSetting = "appsettings.json";
        private const string GoogleApiConfigSection = "ConnectionStrings:GoogleAPIKey";
        private const string TBRDataBasseConfigSection = "ConnectionStrings:TBRDataBaseKey";

        public static string GetGoogleApiKey()
        {
            return GetIConfigurationRoot()[GoogleApiConfigSection];
        }
        public static string GetTBRDataBaseKey()
        {
            return GetIConfigurationRoot()[TBRDataBasseConfigSection];
        }

        public static IConfigurationRoot GetIConfigurationRoot()
        {
            return new ConfigurationBuilder().AddJsonFile(AppSetting).Build();
        }

    }
}
