using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Data.Entities
{
    public class Dummy
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        public string? LastName { get; set; }
        public int Age { get; set; }
    }
}
