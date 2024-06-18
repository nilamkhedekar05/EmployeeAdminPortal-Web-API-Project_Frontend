
using EmployeeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDBContext : DbContext
    {
        //public ApplicationDBContext(DBContextOptions<ApplicationDBContext> options) : (base options)
        //{
        //}
        public ApplicationDBContext(DbContextOptions options) : base(options)
        { 

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
