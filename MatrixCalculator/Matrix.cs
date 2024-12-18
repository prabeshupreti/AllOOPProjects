

namespace MatrixCalculator
{
    public class Matrix
    {
        public int[,] M;

        public Matrix(int FirstDimension, int SecondDimension)
        {
            M = new int[FirstDimension, SecondDimension];
        }

        public static Matrix operator +(Matrix Left, Matrix Right) 
        {
            if (Left.M.GetLength(0) != Right.M.GetLength(0) && Left.M.GetLength(1) != Right.M.GetLength(1)) 
            {
                throw new ArgumentException("Matrices dimension are not equal");
            }

            Matrix MatrixSum = new (Left.M.GetLength(0), Left.M.GetLength(1));

            foreach (int i in Enumerable.Range(0, MatrixSum.M.GetLength(0)))
            {
                foreach (int j in Enumerable.Range(0, MatrixSum.M.GetLength(1)))
                {
                    MatrixSum.M[i, j] = Left.M[i, j] + Right.M[i, j];
                }
            }
            return MatrixSum;
        }
    }
}
