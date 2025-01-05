
namespace DatabaseOperations
{
    public class DepartmentService
    {
        public void AddDepartment(Department department)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Departments.Add(department);
            appDbContext.SaveChanges();
        }

        public Department[] ViewAllDepartments()
        {
            AppDbContext appDbContext = new AppDbContext();
            var departments = appDbContext.Departments.ToArray();
            return departments;
        }

        public Department GetDepartmentById(int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            var departmentValue = appDbContext.Departments.Where(x => x.Id == id).FirstOrDefault();
            return departmentValue;
        }

        public void UpdateDepartment(Department department)
        {
            AppDbContext appDbContext = new AppDbContext();
            var departments = appDbContext.Departments.Update(department);
            appDbContext.SaveChanges();
        }

        public void DeleteDepartment(int Id)
        {
            AppDbContext appDbContext = new AppDbContext();
            Department department = GetDepartmentById(Id);
            var departments = appDbContext.Departments.Remove(department);
            appDbContext.SaveChanges();
        }
    }
}
