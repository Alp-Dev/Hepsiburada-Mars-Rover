using DataModel.Enums;

namespace DataModel.Models.Implementations
{
    public class Rover : IRover
    {
        public CardinalDirectionEnumeration CardinalDirection { get; private set; }

        public IPoint XDimension { get; private set; }

        public IPoint YDimension { get; private set; }

        public Rover(IPoint xDimension, IPoint yDimension, CardinalDirectionEnumeration direction)
        {
            YDimension = yDimension;
            XDimension = xDimension;
            CardinalDirection = direction;
        }

        public void Turn(DirectionEnumeration directionToTurn)
        {
            switch (CardinalDirection)
            {
                case CardinalDirectionEnumeration.N:
                    CardinalDirection = directionToTurn == DirectionEnumeration.R ? CardinalDirectionEnumeration.E : CardinalDirectionEnumeration.W;
                    break;
                case CardinalDirectionEnumeration.S:
                    CardinalDirection = directionToTurn == DirectionEnumeration.R ? CardinalDirectionEnumeration.W : CardinalDirectionEnumeration.E;
                    break;
                case CardinalDirectionEnumeration.E:
                    CardinalDirection = directionToTurn == DirectionEnumeration.R ? CardinalDirectionEnumeration.S : CardinalDirectionEnumeration.N;
                    break;
                case CardinalDirectionEnumeration.W:
                    CardinalDirection = directionToTurn == DirectionEnumeration.R ? CardinalDirectionEnumeration.N : CardinalDirectionEnumeration.S;
                    break;
                default:
                    break;
            }
        }

        public void Move()
        {
            switch (CardinalDirection)
            {
                case CardinalDirectionEnumeration.N:
                    YDimension.Value++;
                    break;
                case CardinalDirectionEnumeration.S:
                    YDimension.Value--;
                    break;
                case CardinalDirectionEnumeration.E:
                    XDimension.Value++;
                    break;
                case CardinalDirectionEnumeration.W:
                    XDimension.Value--;
                    break;
                default:
                    break;
            }
        }
    }
}
