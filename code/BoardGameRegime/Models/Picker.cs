using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BoardGameRegime.Models
{
    public class Picker
    {
        [Required]
        public int Time { get; set; }
        [Required]
        public int Players { get; set; }
        [Range(0, 5)]
        public int Complexity { get; set; }
        public string Theme { get; set; }
    }
}