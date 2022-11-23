using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooseGame.Business.Squares;

namespace GooseGame.Business;

public class PlayerModel : INotifyPropertyChanged
{
    private int _position;

    public PlayerModel()
    {
        FirstThrow = true;
        Position = 1;
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

    public int X => (Position / 8) + 2;

    public int Y => (Position % 8) + 1;

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

        Debug.WriteLine($"Moved from {PreviousPosition} to {Position}|| {X}:{Y}");
        CurrentSquare.HandlePlayer(this);
    }

    public int[] RollDie()
    {
        // TODO: What with the edge cases? See document
        Random random = new Random();
        int[] dice = new int[2];
        dice[0] = random.Next(1, 6);
        dice[1] = random.Next(1, 6);
        
        // TODO: Add to logger and display
        string result = $"Rolled a {dice[0]} and {dice[1]}";
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