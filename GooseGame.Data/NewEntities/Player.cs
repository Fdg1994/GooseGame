namespace GooseGame.Data.NewEntities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public List<PlayedGame> PlayedGames { get; set; }
        public List<PlayerSpecialSquaresHit> PlayerSpecialSquaresHits { get; set; }
    }
}