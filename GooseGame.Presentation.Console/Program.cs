using GooseGame.Business;
using GooseGame.Business.Models;

BusinessRepository game = new BusinessRepository();
DummyModel dummy = game.CreateDummyEntity();
//game.AddDummy(dummy);
//Console.WriteLine("Gelukt");
Console.WriteLine(dummy.Talk());