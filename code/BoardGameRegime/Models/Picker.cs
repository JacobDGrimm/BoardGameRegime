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
        [Required(ErrorMessage ="Number of players is required")]
        public int Players { get; set; }
        [Range(1, 5, ErrorMessage ="Please set between 1 - 5")]
        public int Complexity { get; set; }
        public string Theme { get; set; }
    }
}