namespace GooseGame.Business.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string Talk()
        {
            return $"{Name} talks.";
        }
    }
}