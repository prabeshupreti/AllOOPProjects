
using DatabaseOperations;

int Choice;
DepartmentService departmentService = new DepartmentService();

Console.WriteLine("Select your actions:\n");
Console.WriteLine("1. Add a department");
Console.WriteLine("2. View all departments");
Console.Write("\n What is your choice ?:");
Choice = int.Parse(Console.ReadLine());

//Complete the code with switch case how ever you want to.