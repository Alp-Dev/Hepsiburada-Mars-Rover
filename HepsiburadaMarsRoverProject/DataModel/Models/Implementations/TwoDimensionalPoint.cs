namespace DataModel.Models.Implementations
{
    public class TwoDimensionalPoint : ITwoDimensionalPoint
    {
        public IPoint XDimension { get; }

        public IPoint YDimension { get; }

        public TwoDimensionalPoint(IPoint xDimension, IPoint yDimension)
        {
            XDimension = xDimension;
            YDimension = yDimension;
        }
    }
}
