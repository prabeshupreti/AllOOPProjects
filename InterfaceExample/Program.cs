
using InterfaceExample;

IShape circle = new Circle(5);
IShape Square = new Square(6);

Console.WriteLine($"Circle Area: {circle.Area()}");
Console.WriteLine($"Circle Perimeter: {circle.Perimeter()}");

Console.WriteLine($"Square Area: {Square.Area()}");
Console.WriteLine($"Square Perimeter: {Square.Perimeter()}");