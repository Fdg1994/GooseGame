using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Data.Entities
{
    public class Player_SpecialSquareHitEntity
    {
        [Key]
        public int Id { get; set; }
        public PlayerEntity PlayerHitInfo { get; set; }
        public int SquareNumberHit { get; set; }
        public DateTime DateAndTimeHit { get; set; }
    }
}
