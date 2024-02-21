using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI.DatabaseContext
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=kdac;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
