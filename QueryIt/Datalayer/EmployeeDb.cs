using System.Data.Entity;
using QueryIt.Domain;

namespace QueryIt.Datalayer
{
    public class EmployeeDb:DbContext
    {
        public DbSet<Employee> Employees { get; set; } 
    }
}