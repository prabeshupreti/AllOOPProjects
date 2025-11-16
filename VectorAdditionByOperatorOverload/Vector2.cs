
using System.Drawing;

namespace VectorAdditionByOperatorOverload
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

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X + b.X, a.Y + b.Y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        #region Below code is not used in this example
        public static bool operator ==(Vector2 a, Vector2 b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            return obj is Vector2 p && this == p;
        }

        public override int GetHashCode()
        {

        return HashCode.Combine(X, Y);
        }
        #endregion
    }
}
