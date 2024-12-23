
using MatrixCalculatorImproved;

Matrix matrixA = new Matrix(2, 2);

Matrix matrixB = new Matrix(2, 2);

Console.WriteLine("Enter the matrix A numbers");
foreach (int i in Enumerable.Range(0, matrixA.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, matrixA.GetLength(1)))
    {
        matrixA[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("Enter the matrix B numbers");
foreach (int i in Enumerable.Range(0, matrixB.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, matrixA.GetLength(1)))
    {
        matrixB[i, j] = int.Parse(Console.ReadLine());
    }
}

Matrix MatrixSum = matrixA + matrixB;

Console.WriteLine();
foreach (int i in Enumerable.Range(0, MatrixSum.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, MatrixSum.GetLength(1)))
    {
        Console.WriteLine(MatrixSum[i, j]);
    }
}