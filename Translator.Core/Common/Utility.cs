using System;
using System.Configuration;
using System.Reflection;

namespace Translator.Core.Common
{
    public static class Utility
    {
        public static string GetConnectionString()
        {
            //Configuration config = null;
            string exeConfigPath = Assembly.GetExecutingAssembly().Location;
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(exeConfigPath).ConnectionStrings
                    .ConnectionStrings["TranslatorContext"].ConnectionString;
                return config;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
        }
    }
}
