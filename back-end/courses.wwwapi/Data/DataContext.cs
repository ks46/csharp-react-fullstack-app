using courses.wwwapi.Models;
using Microsoft.EntityFrameworkCore;

namespace courses.wwwapi.Data
{
    public class DataContext : DbContext
    {
        private string connectionString;

        public DataContext()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Declaration> Declarations { get; set; }

    }
}
