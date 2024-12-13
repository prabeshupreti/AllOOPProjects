using Documentation;

Calculator calculator = new Calculator();

Console.Write("Enter the first number: ");
calculator.Number1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
calculator.Number2 = int.Parse(Console.ReadLine());

int Sum = calculator.Add();

Console.WriteLine($"The sum is {Sum}.");

int Diff = calculator.Difference();

Console.WriteLine($"The difference is {Diff}.");