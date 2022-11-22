using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Data.Entities
{
    public class PlayerEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public List<GameEntity> GamesPlayed { get; set; }
        public ICollection<Player_SpecialSquareHitEntity> SpecialSquaresHit { get; set; }
    }
}
