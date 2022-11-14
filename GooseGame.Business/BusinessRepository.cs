using GooseGame.Business.Models;
using GooseGame.Data.Entities;
using GooseGame.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Business
{
    public class BusinessRepository
    {
        public BusinessRepository() { }
        
        public void AddSquare(Square square)
        {
            //MAPPING (!)
            Square newSquare = new Square
            {
                //????????????
                Pos = square.Pos,
            };
        }

        public abstract class Player
        {
            public int Id { get; set; }
            public int Pos { get; set; }
        }

        public abstract class Square
        {
            public int Pos { get; set; }
        }
        public class GooseSquare : Square
        {
            public int TilesSkipped { get; set; }
        }
        public class SkipSquare : Square
        {
            public int TurnsSkipped { get; set; }
        }

        public abstract class Creator
        {
            public abstract Square Factory();
        }
        public class CreatorGoose : Creator
        {
            public override Square Factory()
            {
                return new GooseSquare();
            }
        }
        public class CreatorSkip : Creator
        {
            public override Square Factory()
            {
            return new SkipSquare();
            }
        }
    }
}