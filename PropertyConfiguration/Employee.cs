
namespace PropertyConfiguration
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name 
        { 
            get 
            {
                return $"{FirstName} {LastName}";
            } 
        }
    }
}
