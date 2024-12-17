

namespace MatrixCalculator
{
    public class Matrix
    {
        public int[,] M;

        public Matrix(int FirstDimension, int SecondDimension)
        {
            M = new int[FirstDimension, SecondDimension];
        }
    }
}
