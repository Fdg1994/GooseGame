using GooseGame.Business.Squares;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class PlayerModel : INotifyPropertyChanged
{
    public int Id { get; set; }
    public int Position { get; set; }

    private int x;

    public int X
    {
        get { return x; }
        set
        {
            x = value;
            NotifyPropertyChanged(nameof(x));
        }
    }

    private int y;

    public int Y
    {
        get { return y; }
        set
        {
            y = value;
            NotifyPropertyChanged(nameof(y));
        }
    }

    public bool FirstThrow { get; set; }
    public bool StuckInWell { get; set; }
    public int CurrentRoll { get; set; }
    public int TurnsSkip { get; set; }
    public int PreviousPosition { get; set; }
    public string Name { get; set; }

    public PlayerModel()
    {
        FirstThrow = true;
        Position = 1;
        X = 5;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

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

    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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