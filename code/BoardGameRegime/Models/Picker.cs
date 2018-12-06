using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BoardGameRegime.Models
{
    public class Picker
    {
        public int Time { get; set; }
        public int Players { get; set; }
        public int Complexity { get; set; }
        public string Theme { get; set; }
    }
}