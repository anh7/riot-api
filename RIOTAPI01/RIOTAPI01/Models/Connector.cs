using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RIOTAPI01.Common;

namespace RIOTAPI01.Models
{
    public class Connector
    {
        public string key { get; set; }
        public Connector()
        {
            //key = Utility.GetAppSettings()
        }
    }
}
