using Microsoft.EntityFrameworkCore;
using WebServices.Models;

namespace WebServices.Data
{
    public class WebServicesDbContext : DbContext
    {
        public WebServicesDbContext() { }

        public WebServicesDbContext(DbContextOptions<WebServicesDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=DbWbServices;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
    }
}
