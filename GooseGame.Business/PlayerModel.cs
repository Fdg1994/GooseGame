using GooseGame.Business.Squares;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GooseGame.Business;

public class PlayerModel : INotifyPropertyChanged
{
    private int _position;

    public PlayerModel()
    {
        FirstThrow = true;
        Name = "Default";
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public int CurrentRoll { get; set; }
    public ISquare CurrentSquare => Gameboard.GetInstance().Squares[Position];
    public bool FirstThrow { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }

    public int Position
    {
        get => _position;
        set
        {
            _position = value;
            NotifyPropertyChanged(nameof(Position));
        }
    }

    public string Image { get; set; } = "Resources/Images/PLAYER1.png";

    public int PreviousPosition { get; set; }

    public bool StuckInWell { get; set; }

    public int TurnsSkip { get; set; }

    public int[,] myGrid = new int[8, 8];

    public void MovePlayer(int roll)
    {
        PreviousPosition = Position;
        if (Position + roll <= 63) //If player roll + position exceeds 63, the player will move until he hits 63 and then move in reverse for the remaining roll numbers.
        {
            Position += roll;
        }
        else
        {
            Position = 63 - (roll - (63 - Position));
            CurrentRoll = -CurrentRoll; //Player will move twice as much backwards if he hits a goose in reverse.
        }

        CurrentSquare.HandlePlayer(this);
    }

    public int[] RollDie()
    {
        Random random = new Random();
        int[] dice = new int[2];
        dice[0] = random.Next(1, 7);
        dice[1] = random.Next(1, 7);

        string result = $"Rolled a {dice[0]} and {dice[1]} Current position: {Position + dice[0] + dice[1]}";
        Debug.WriteLine(result);

        CurrentRoll = dice[0] + dice[1];
        return dice;
    }

    public void SetPlayerPosition(int positionSet)
    {
        Position = positionSet;
    }

    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}