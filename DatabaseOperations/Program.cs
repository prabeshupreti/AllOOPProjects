
using DatabaseOperations;

int Choice;
DepartmentService departmentService = new DepartmentService();

Beginning:

Console.WriteLine("\nSelect your actions:\n");
Console.WriteLine("1. Add a department");
Console.WriteLine("2. View all departments");
Console.WriteLine("3. Update a department");
Console.WriteLine("4: Delete a department");
Console.Write("\n What is your choice ?: ");
Choice = int.Parse(Console.ReadLine());

if (!(Choice >= 1 || Choice <= 4))
{
    Console.Clear();
    Console.WriteLine("Wrong choice selected.\n");
    goto Beginning;
}

Console.WriteLine();
switch (Choice)
{
    case 1:
        {
            Department department = new Department();
            Console.Write("Enter the department name you want to add: ");
            department.Name = Console.ReadLine();
            departmentService.AddDepartment(department);
            Console.WriteLine("The department record is added.");
            break;
        }

    case 2:
        var departments = departmentService.ViewAllDepartments();
        Console.WriteLine("Below are all the departments: ");

        foreach (var departmentItem in departments)
        {
            Console.WriteLine($"\nId:{departmentItem.Id} Name:{departmentItem.Name}");
        }
        break;

    case 3:
        {
            Department department = new Department();
            Console.Write("Enter the id of the department record you want to update: ");
            department.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter the updated name: ");
            department.Name = Console.ReadLine();
            departmentService.UpdateDepartment(department);
            Console.WriteLine("The department record is updated.");
        }
        break;

    case 4:
        Console.Write("Enter the id of the department record you want to delete: ");
        int Id = int.Parse(Console.ReadLine());
        departmentService.DeleteDepartment(Id);
        Console.WriteLine("The department record is updated.");
        break;
}

Console.WriteLine("\nDo you want perform more operations? (y/n):");
string yn = Console.ReadLine();

if (yn == "Y" || yn == "y") 
{
    goto Beginning;
}