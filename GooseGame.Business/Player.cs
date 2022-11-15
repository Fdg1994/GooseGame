using System;
using GooseGame.Business;
using GooseGame.Business.Models;


public class Player
{
        public int Id { get; set; }
        public int Pos { get; set; }
        public bool IsTurn { get; set; }

    public int RollDie()
    {
        Random random = new Random();
        var die = random.Next(2, 12);
        return die;
    }
}
