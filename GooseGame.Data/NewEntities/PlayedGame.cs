namespace GooseGame.Data.NewEntities
{
    public class PlayedGame
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
    }
}