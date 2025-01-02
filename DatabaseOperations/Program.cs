
using DatabaseOperations;


AppDbContext appDbContext = new AppDbContext();
Department department = new Department();

Console.WriteLine("Enter the department name: ");

department.Name = Console.ReadLine();

appDbContext.Departments.Add(department);
appDbContext.SaveChanges();