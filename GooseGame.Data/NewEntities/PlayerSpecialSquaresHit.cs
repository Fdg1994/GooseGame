namespace GooseGame.Data.NewEntities
{
    public class PlayerSpecialSquaresHit
    {
        public int PlayerId { get; set; }
        public Player? Player { get; set; }
        public int SpecialSquaresHitId { get; set; }
        public SpecialSquaresHit? SpecialSquaresHit { get; set; }
    }
}