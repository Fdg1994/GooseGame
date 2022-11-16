using System;
using GooseGame.Business;
using GooseGame.Business.Models;
using GooseGame.Business.Squares;

public class Gameboard
{
    Player player1 = new Player();
    ISquare[] arraySquares = new ISquare[63];
    int[] arrayGooseSquares = new int[13] { 5, 9, 14, 18, 23, 27, 32, 36, 41, 45, 50, 54, 59 };
    int[] arraySpecials = new int[7] { 6, 19, 31, 42, 52, 58, 63 };
    

    public void CheckGoose()
    {
        for (int i = 0; i < arraySquares.Length; i++)
        {
            if (player1.Pos == arrayGooseSquares[i])
            {
                //execute goose/skip
            }
        }
    }
    public void CheckSpecials()
    {
        for (int i = 0; i < arraySpecials.Length; i++)
        {
            if (player1.Pos == arraySpecials[i])
            {
                //execute specials
            }
        }
    }

    static void CheckType(int position)
    {
        
        switch (position)
        {
            case 6:
                player1.Pos = 12;
                break;
            case 19:
                //skip 1 turn
                break;
            case 31:
                //wait for other player
                break;
            case 42:
                player1.Pos = 39;
                break;
            case 52:
                //skip 3 turns
                break;
            case 58:
                player1.Pos = 0;
                break;
            case 63:
                //Wincon
                break;
        }
    }
}
