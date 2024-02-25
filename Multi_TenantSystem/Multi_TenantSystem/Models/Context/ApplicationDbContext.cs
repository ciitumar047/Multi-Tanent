using Microsoft.EntityFrameworkCore;
using Multi_TenantSystem.Models.Model;

namespace Multi_TenantSystem.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConfiguration> TenantConfigurations { get; set; }
        //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TenantConfiguration>()
                .HasOne(tc => tc.Tenant)
                .WithMany(t => t.TenantConfiguration)
                .HasForeignKey(tc => tc.TenantId);
        }
    }
}
