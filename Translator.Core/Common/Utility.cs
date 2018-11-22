using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
