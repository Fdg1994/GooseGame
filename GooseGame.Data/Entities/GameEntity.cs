using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Data.Entities
{
    public class GameEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int PlayerEntityId { get; set; }
        public PlayerEntity Winner { get; set; }
        public int AmountOfThrows { get; set; }
    }
}
