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
        X = 1;
        Y = 1;
        XShowOnBoard(X);
        YShowOnBoard(Y);
        Name = "Default";
        DrawGrid();
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

    // public int X => XShowOnBoard(Position);

    // public int Y => YShowOnBoard(Position);
    public int _x;
    public int _y;

    public int X { get { return XShowOnBoard(Position); } set { _x = value; } }
    public int Y { get { return YShowOnBoard(Position); } set { _y = value; } }

    public void DrawGrid()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
               myGrid[j, i] = i % 2 == 0 ? i * 8 + j : (i * 8 + 8 - j) - 1;
            }
        }
    }

int XShowOnBoard(int location)
{
    DrawGrid();
    int x = 0;
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (myGrid[j, i] == location)
            {
                x = j + 1;
                    return x;
            }
        }
    }
        throw new Exception();
}
int YShowOnBoard(int location)
{
    DrawGrid();
    int y = 0;
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (myGrid[j, i] == location)
            {
                y = i + 1;
                    return y;
            }
        }
    }
        throw new Exception();
}



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