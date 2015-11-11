using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Common
{
    public class Config
    {
        public static string GetAppSetting(string key)
        {
            string result = string.Empty;
            var uri = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase));
            var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = Path.Combine(uri.LocalPath, Assembly.GetExecutingAssembly().FullName.Split(',')[0] + ".dll.config") };
            var assemblyConfig = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            if (assemblyConfig.HasFile)
            {
                AppSettingsSection section = (assemblyConfig.GetSection("appSettings") as AppSettingsSection);
                result = section.Settings[key].Value;
            }

            return result;
        }
    }
}
