using Calculator;

Calc calc = new Calc();

Console.Write("Enter the first number: ");
calc.Number1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
calc.Number2 = int.Parse(Console.ReadLine());

int Sum = calc.Add();

Console.WriteLine($"The sum is {Sum}.");

int Diff = calc.Difference();

Console.WriteLine($"The difference is {Diff}.");