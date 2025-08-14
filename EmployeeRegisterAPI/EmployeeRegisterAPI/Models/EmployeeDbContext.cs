using Microsoft.EntityFrameworkCore;

namespace EmployeeRegisterAPI.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options):base(options)
        {

        }


        // Add this constructor for design-time context creation
        public EmployeeDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("DevConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<EmployeeModel> Employees { get; set; } = null!;
    }
}
