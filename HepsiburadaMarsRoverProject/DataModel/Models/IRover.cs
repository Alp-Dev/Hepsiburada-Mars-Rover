using DataModel.Enums;

namespace DataModel.Models
{
    public interface IRover : ITwoDimensionalPoint
    {
        CardinalDirectionEnumeration CardinalDirection { get; }

        void Turn(DirectionEnumeration turnEnumeration);

        void Move();
    }
}
