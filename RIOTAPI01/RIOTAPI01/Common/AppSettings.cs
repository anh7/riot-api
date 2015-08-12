using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIOTAPI01.Common
{
    public static class AppSettings
    {
        public static class Common
        {
            public static string APIKey { get { return Utility.GetAppSettings(Constants.Common.APIKey); } }
        }
        public static class APIURL
        {
            public static string Summoner { get { return Utility.GetAppSettings(Constants.APIURL.Summoner); } }
        }
    }
}
