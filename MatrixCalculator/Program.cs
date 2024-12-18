
using MatrixCalculator;

Matrix matrixA = new Matrix(2, 2);

Matrix matrixB = new Matrix(2, 2);
Matrix Sum = matrixA + matrixB;

for (int i = 0; i < Sum.M.GetLength(0); i++)
{
    for (int j = 0; j < Sum.M.GetLength(1); j++)
    {
        Console.Write($"   {Sum.M[i, j]}");
    }
    Console.WriteLine();
}