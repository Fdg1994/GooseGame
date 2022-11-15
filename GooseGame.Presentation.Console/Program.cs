using GooseGame.Business;
using GooseGame.Business.Models;
using System;

public Square[] arraySquares = new Square[62];



BusinessRepository game = new BusinessRepository();
DummyModel dummy = game.CreateDummyEntity();
//game.AddDummy(dummy);
//Console.WriteLine("Gelukt");
Console.WriteLine(dummy.Talk());