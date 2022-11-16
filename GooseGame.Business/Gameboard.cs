﻿using System;
using GooseGame.Business;
using GooseGame.Business.Models;
using GooseGame.Business.SquareFactory;
using GooseGame.Business.Squares;

public class Gameboard
{
    Player player1 = new Player();
    ISquare[] arraySquares = new ISquare[63];
    int[] arrayGooseSquares = new int[13] { 5, 9, 14, 18, 23, 27, 32, 36, 41, 45, 50, 54, 59 };


    List<ISquare> Squares { get; set; } = new List<ISquare>();

    public Gameboard()
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

        foreach(int i in arrayGooseSquares)
        {
            Squares.Add(SquareFactory.CreateSquare(SquareType.Goose));
        }

        Squares[bridgeSquare - 1] = SquareFactory.CreateSquare(SquareType.Bridge);
        Squares[innSquare - 1] = SquareFactory.CreateSquare(SquareType.Inn);
        Squares[wellSquare - 1] = SquareFactory.CreateSquare(SquareType.Well);
        Squares[mazeSquare - 1] = SquareFactory.CreateSquare(SquareType.Maze);
        Squares[prisonSquare - 1] = SquareFactory.CreateSquare(SquareType.Prison);
        Squares[deathSquare - 1] = SquareFactory.CreateSquare(SquareType.Death);
        Squares[endSquare - 1] = SquareFactory.CreateSquare(SquareType.End);

    }

    public int RollDie() //need to implement first throw method and use 2 rolls to check the 5+4 and 6+3 thing
    {
        Random random = new Random();
        var die = random.Next(1, 6);
        return die;
    }
}
