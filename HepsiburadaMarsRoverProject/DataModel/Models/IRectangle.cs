using System.Collections.Generic;

namespace DataModel.Models
{
    public interface IRectangle
    {
        IEnumerable<ITwoDimensionalPoint> Coordinates { get; }
    }
}
