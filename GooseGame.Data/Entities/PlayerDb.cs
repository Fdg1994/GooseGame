using System.ComponentModel.DataAnnotations;

namespace GooseGame.Data.Entities
{
    public class PlayerDb
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }
    }
}