using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIOTAPI01.Models.Summoner
{
    public class Summoner
    {
        public long? id { get; set; }
        public string name { get; set; }
        public int? profileIconId { get; set; }
        public int? summonerLevel { get; set; }
        public DateTime? revisionDate { get; set; }
    }
}
