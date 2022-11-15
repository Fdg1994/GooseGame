using System;
using GooseGame.Business;
using GooseGame.Business.Models;
using GooseGame.Business.Squares;

public class Gameboard
{
    Player player1 = new Player();
    ISquare[] arraySquares = new ISquare[63];

    static void CheckType(int position)
    {
        switch (position)
        {
            case 6:
                //goto12
                break;
            case 19:
                //skip 1 turn
                break;
            case 31:
                //wait for other player
                break;
            case 42:
                //gobackto39
                break;
            case 52:
                //skip 3 turns
                break;
            case 58:
                //back to start
                break;
            case 63:
                //Wincon
                break;
        }
    }

    int[] arrayGooseSquares = new int[13] { 5, 9, 14, 18, 23, 27, 32, 36, 41, 45, 50, 54, 59 };

    
    
    
}
