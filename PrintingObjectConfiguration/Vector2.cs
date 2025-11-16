
namespace PrintingObjectConfiguration
{
    public class Vector2
    {
        public int X { get; }
        public int Y { get; }

        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Override ToString to provide a custom string representation
        //when you print the object
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
