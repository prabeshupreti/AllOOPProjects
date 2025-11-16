
using NestedOrCustomClass;

Employee employee = new Employee();
Address address = new Address();

Console.Write("Enter an Id: ");
employee.Id = int.Parse(Console.ReadLine());

Console.Write("Enter First Name: ");
employee.FirstName = Console.ReadLine();

Console.Write("Enter Last Name: ");
employee.LastName = Console.ReadLine();

Console.Write("Enter Street: ");
address.Street = Console.ReadLine();

Console.Write("Enter City: ");
address.City = Console.ReadLine();

Console.Write("Enter State: ");
address.State = Console.ReadLine();

Console.Write("Enter Zip Code: ");
address.ZipCode = Console.ReadLine();

Console.Write("Enter Contact Number: ");
employee.Contact = Console.ReadLine();

employee.Address = address;

Console.WriteLine();

Console.WriteLine("Employee Details:");
Console.WriteLine($"Id: {employee.Id}");
Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}");
Console.WriteLine("Address:");
Console.WriteLine($"  Street: {employee.Address.Street}");
Console.WriteLine($"  City: {employee.Address.City}");
Console.WriteLine($"  State: {employee.Address.State}");
Console.WriteLine($"  Zip Code: {employee.Address.ZipCode}");
Console.WriteLine($"Contact Number: {employee.Contact}");

