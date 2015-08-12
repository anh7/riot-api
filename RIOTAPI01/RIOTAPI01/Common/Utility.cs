using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RIOTAPI01.Common
{
    public static class Utility
    {
        public static string GetAppSettings(string key)
        {
            if (string.IsNullOrEmpty(key))
                return string.Empty;
            return ConfigurationManager.AppSettings[key];
        }
    }
}
