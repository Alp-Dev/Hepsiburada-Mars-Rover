namespace DataModel.Models.Implementations
{
    public class Point : IPoint
    {
        public int Value { get; set; }

        public Point(int value)
        {
            Value = value;
        }
    }
}
