
using ErrorHandling;

Calculator calculator = new Calculator();

Console.Write("Enter a number: ");
calculator.Number1 = int.Parse(Console.ReadLine());

Console.Write("Enter another number: ");
calculator.Number2 = int.Parse(Console.ReadLine());

try
{
    int Diff = calculator.Division();

    Console.WriteLine($"The division is {Diff}.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}