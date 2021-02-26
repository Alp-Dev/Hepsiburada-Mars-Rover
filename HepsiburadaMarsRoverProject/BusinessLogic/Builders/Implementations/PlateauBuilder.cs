using DataModel.Models;
using DataModel.Models.Implementations;
using System.Collections.Generic;

namespace BusinessLogic.Builders.Implementations
{
    public class PlateauBuilder : IBuilder<ITwoDimensionalPoint, Plateau>
    {
        public Plateau Build(ITwoDimensionalPoint input)
        {
            IEnumerable<ITwoDimensionalPoint> coordinates = GenerateCoordinatesFromTwoDimensionalPoint(input);
            return new Plateau(coordinates);
        }

        private IEnumerable<ITwoDimensionalPoint> GenerateCoordinatesFromTwoDimensionalPoint(ITwoDimensionalPoint input)
        {
            var coordinates = new List<TwoDimensionalPoint>();

            for (int i = 0; i <= input.XDimension.Value; i++)
            {
                for (int j = 0; j <= input.YDimension.Value; j++)
                {
                    coordinates.Add(new TwoDimensionalPoint(new Point(i), new Point(j)));
                }
            }
            return coordinates;
        }
    }
}
