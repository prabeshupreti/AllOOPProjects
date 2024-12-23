using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculatorImproved
{
    public class Matrix
    {
        private int[,] M;

        public Matrix(int FirstDimension, int SecondDimension)
        {
            M = new int[FirstDimension, SecondDimension];
        }

        public int this[int row, int col]
        {
            get
            {
                return M[row, col];
            }
            set
            {
                M[row, col] = value;
            }
        }

        public int GetLength(int Dimension)
        {
            return M.GetLength(Dimension);
        }

        public static Matrix operator +(Matrix Left, Matrix Right)
        {
            if (Left.M.GetLength(0) != Right.M.GetLength(0) && Left.M.GetLength(1) != Right.M.GetLength(1))
            {
                throw new ArgumentException("Matrices dimension are not equal");
            }

            Matrix MatrixSum = new(Left.M.GetLength(0), Left.M.GetLength(1));

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
