using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameRegime.Entities
{
    public class Games
    {
        public string Title {get; set;}
        public int GameLength { get; set; }
        public string Publisher { get; set; }
        public string Designer { get; set; }
        public int MinPlayer { get; set; }
        public int MaxPlayer { get; set; }
        public int RecPlayer { get; set; }
        public string Mechanism { get; set; }
        public string Theme { get; set; }
        public int Complexity { get; set; }
    }
}