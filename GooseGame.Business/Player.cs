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
    public int Skips { get; set; }

    public Player()
    {
        Skips = 0;
        FirstThrow = true;
        Position = 1;
    }

    public int[] RollDie()
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
        if (Position + roll > 63) //If player roll + position exceeds 63, the player will move until he hits 63 and then move in reverse for the remaining roll numbers.
        {
            Position = 63 - (roll - (63 - Position));
            CurrentRoll = -CurrentRoll; //Player will move twice as much backwards if he hits a goose in reverse.
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