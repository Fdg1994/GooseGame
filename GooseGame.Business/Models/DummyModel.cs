namespace GooseGame.Business.Models
{
    public class DummyModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        public string Talk()
        {
            return $"{FirstName} talks.";
        }
    }
}