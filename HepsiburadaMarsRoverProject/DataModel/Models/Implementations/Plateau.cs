using System.Collections.Generic;

namespace DataModel.Models.Implementations
{
    public class Plateau : IRectangle
    {
        public IEnumerable<ITwoDimensionalPoint> Coordinates { get; }

        public Plateau(IEnumerable<ITwoDimensionalPoint> coordinates)
        {
            Coordinates = coordinates;
        }

    }
}
