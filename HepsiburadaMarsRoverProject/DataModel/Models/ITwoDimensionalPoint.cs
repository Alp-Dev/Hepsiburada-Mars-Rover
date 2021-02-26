namespace DataModel.Models
{
    public interface ITwoDimensionalPoint
    {
        IPoint XDimension { get; }
        IPoint YDimension { get; }
    }
}