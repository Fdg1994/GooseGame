using System;
using GooseGame.Business;
using GooseGame.Business.Models;


public class Player
{
    public int Id { get; set; }
    public int Pos { get; set; }
    public bool IsTurn { get; set; }
    public int Turns { get; set; }

    public int RollDie() //need to implement first throw method and use 2 rolls to check the 5+4 and 6+3 thing
    {
        Random random = new Random();
        var die = random.Next(2, 12);
        return die;
    }
}
