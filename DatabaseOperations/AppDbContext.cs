

using Microsoft.EntityFrameworkCore;

namespace DatabaseOperations
{
    public class AppDbContext : DbContext
    {

        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = "server=localhost;uid=root;database=OfficeDemoApp";
            optionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));
            base.OnConfiguring(optionsBuilder); 
        }
    }
}
