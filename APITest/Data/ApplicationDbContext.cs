using APITest.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace APITest.Data
{
    public class ApplicationDbContext:DbContext
    {
        // pass constructe with the ApplicationDbcontext parameter & instance to base class as well
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
    }
        //Property set for Dbset type for DB collection
        public DbSet<Employee> Employees { get; set; }


    }
}
