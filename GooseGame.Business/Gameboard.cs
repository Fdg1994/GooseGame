﻿using GooseGame.Business.SquareFactory;
using GooseGame.Business.Squares;

public class Gameboard
{
    private ISquare[] arraySquares = new ISquare[63];
    private int[] arrayGooseSquares = new int[13] { 5, 9, 14, 18, 23, 27, 32, 36, 41, 45, 50, 54, 59 };
    
    public List<ISquare> Squares { get; set; } = new List<ISquare>();

    private static Gameboard _instance;

    public static Gameboard GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Gameboard();
        }
        return _instance;
    }

    private Gameboard()
    {
        const int bridgeSquare = 6;
        const int innSquare = 19;
        const int wellSquare = 31;
        const int mazeSquare = 42;
        const int prisonSquare = 52;
        const int deathSquare = 58;
        const int endSquare = 63;

        for (int i = 0; i < arraySquares.Length; i++)
        {
            Squares.Add(SquareFactory.CreateSquare(SquareType.Default));
        }

        foreach (int i in arrayGooseSquares)
        {
            Squares.Add(SquareFactory.CreateSquare(SquareType.Goose));
        }

        Squares[bridgeSquare] = SquareFactory.CreateSquare(SquareType.Bridge);
        Squares[innSquare] = SquareFactory.CreateSquare(SquareType.Inn);
        Squares[wellSquare] = SquareFactory.CreateSquare(SquareType.Well);
        Squares[mazeSquare] = SquareFactory.CreateSquare(SquareType.Maze);
        Squares[prisonSquare] = SquareFactory.CreateSquare(SquareType.Prison);
        Squares[deathSquare] = SquareFactory.CreateSquare(SquareType.Death);
        Squares[endSquare] = SquareFactory.CreateSquare(SquareType.End);
    }
}