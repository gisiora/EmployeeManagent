using EmployeeMangement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMangement.context
{
    public class ApplicationDbContext:DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>contextOptions)
        :base(contextOptions)
        {        
             
        }

        //

        public DbSet<Employee> Employees { get; set; }







    }
}
