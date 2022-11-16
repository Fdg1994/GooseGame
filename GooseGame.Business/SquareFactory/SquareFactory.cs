using GooseGame.Business.Squares;

namespace GooseGame.Business.SquareFactory
{
    public class SquareFactory
    {
        public static ISquare CreateSquare(SquareType type)
        {
            switch (type)
            {
                case SquareType.Bridge:
                    {
                        return new Bridge();
                    }
                case SquareType.Inn:
                    {
                        return new Inn();
                    }
                case SquareType.Well:
                    {
                        return new Well();
                    }
                case SquareType.Maze:
                    {
                        return new Maze();
                    }

                case SquareType.Prison:
                    {
                        return new Prison();
                    }
                case SquareType.Death:
                    {
                        return new Death();
                    }
                case SquareType.End:
                    {
                        return new End();
                    }
                default:
                    return null!;
            }
        }
    }
}