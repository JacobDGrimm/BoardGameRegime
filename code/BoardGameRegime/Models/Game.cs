using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

using System.Data.Entity;

namespace BoardGameRegime.Models
{
    public class Game
    {
        [Key]
        [Required(ErrorMessage ="Title is required")]
        public string Title { get; set; }
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

    public class GameDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}