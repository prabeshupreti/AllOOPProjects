
using MatrixCalculator;

Matrix matrixA = new Matrix(2, 2);

Matrix matrixB = new Matrix(2, 2);

Console.WriteLine("Enter the matrix A numbers");
foreach (int i in Enumerable.Range(0, matrixA.M.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, matrixA.M.GetLength(1)))
    {
        matrixA.M[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("Enter the matrix B numbers");
foreach (int i in Enumerable.Range(0, matrixB.M.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, matrixA.M.GetLength(1)))
    {
        matrixB.M[i, j] = int.Parse(Console.ReadLine());
    }
}

Matrix MatrixSum = matrixA + matrixB;

Console.WriteLine();
foreach (int i in Enumerable.Range(0, MatrixSum.M.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, MatrixSum.M.GetLength(1)))
    {
        Console.WriteLine(MatrixSum.M[i, j]);
    }
}