using Microsoft.EntityFrameworkCore;

namespace EmployeeService.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>()
        //        .HasOne<EmployeeAddress>(e => e.EmployeeAddress)
        //        .WithOne(em => em.Employee)
        //        .HasForeignKey<EmployeeAddress>(em => em.empid);
        //}
        public DbSet<Employee> Employee { get; set; }

        public DbSet<EmployeeAddress> EmployeeAddress { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Project> Project { get; set; }

    }
}
