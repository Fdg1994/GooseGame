using GooseGame.Business;
using GooseGame.Business.Models;
using System;

//DummyModel dummy = game.CreateDummyEntity();
//game.AddDummy(dummy);
//Console.WriteLine("Gelukt");
//Console.WriteLine(dummy.Talk());

/*List<ISquare> gameboard = new List<ISquare>();

for (int i = 0; i < gameboard.Count; i++)
{ gameboard.Add(SquareFactory.CreateSquare(SquareType.Default)); } */

Gameboard gameboard = new Gameboard();

int firstDie = gameboard.RollDie();
int secondDie = gameboard.RollDie();

switch (firstDie)
{
    case 5:
        if (secondDie == 4)
        {
            //methodgoto26
        }
        break;
    case 4:
        if (secondDie == 5)
        {

        }
        break;
    case 6:
        if (secondDie == 3)
        {
            //methodgoto39
        }
        break;
    case 3:
        if (secondDie == 6)
        {

        }
        break;
    default:
        throw new Exception();
}
