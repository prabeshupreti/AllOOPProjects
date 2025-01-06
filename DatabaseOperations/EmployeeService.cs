
using Microsoft.EntityFrameworkCore;

namespace DatabaseOperations
{
    public class EmployeeService
    {
        public void AddEmployee(Employee employee)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Employees.Add(employee);
            appDbContext.SaveChanges();
        }

        public Employee[] ViewAllEmployees()
        {
            AppDbContext appDbContext = new AppDbContext();
            var employees = appDbContext.Employees.Include(x => x.Department).ToArray();
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            var employeeValue = appDbContext.Employees
                .Include(x => x.Department)
                .Where(x => x.Id == id).FirstOrDefault();

            return employeeValue;
        }

        public void UpdateEmployee(Employee employee)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Employees.Update(employee);
            appDbContext.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            AppDbContext appDbContext = new AppDbContext();
            var departments = appDbContext.Employees.Remove(employee);
            appDbContext.SaveChanges();
        }
    }
}
