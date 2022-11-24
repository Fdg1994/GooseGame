using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Presentation.WPF.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public string? Name { get; set; }
        public int CurrentRoll { get; set; }
    }
}
