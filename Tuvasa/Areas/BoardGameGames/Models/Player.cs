using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tuvasa.Areas.BoardGameGames.Models
{
    public class Player
    {
        [Key]
        public Guid PlayerID { get; set; }
        [Display(Name = "Nazwa gracza")]
        public string PlayerName { get; set; }
    }
}
