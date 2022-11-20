using GooseGame.Business.Squares;

public class Player
{
    public int Id { get; set; }
    public int Position { get; set; }
    public bool FirstThrow { get; set; }
    public bool StuckInWell { get; set; }
    public int CurrentRoll { get; set; }
    public int TurnsSkip { get; set; }
    public int PreviousPosition { get; set; }
    public string Name { get; set; }

    public Player()
    {
        FirstThrow = true;
        Position = 1;
    }

    public int[] RollDie() //need to implement first throw method and use 2 rolls to check the 5+4 and 6+3 thing
    {
        Random random = new Random();
        int[] dice = new int[2];
        dice[0] = random.Next(1, 6);
        dice[1] = random.Next(1, 6);
        Console.WriteLine($"Rolled a {dice[0]} and {dice[1]}");
        CurrentRoll = dice[0] + dice[1];
        return dice;
    }

    public ISquare CurrentSquare
    {
        get
        {
            return Gameboard.GetInstance().Squares[Position];
        }
    }

    public void MovePlayer(int roll)
    {
        PreviousPosition = Position;
        if (Position + roll > 63)
        {
            Position = 63 - (roll - (63 - Position));
            CurrentRoll = -CurrentRoll;
        }
        else
        {
            Position += roll;
        }
        CurrentSquare.HandlePlayer(this);
    }

    public void SetPlayerPosition(int positionSet)
    {
        Position = positionSet;
    }
}