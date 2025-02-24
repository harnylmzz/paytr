using Microsoft.EntityFrameworkCore;
using paytr.Domain.Entities;

namespace paytr.Persistence.EntityFramework.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<OrderHistory> OrderHistories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Tenant> Tenants { get; set; }

        public DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
