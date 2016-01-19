using CarWash.Domain.Entities;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata.Builders;

namespace CarWash.Infrastructure.EF.Context
{
    public class CarWashContext : DbContext
    {
        public CarWashContext() { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ClientConfiguration(modelBuilder.Entity<Client>());
            CarConfiguration(modelBuilder.Entity<Car>());

            base.OnModelCreating(modelBuilder);
        }

        private static void ClientConfiguration(EntityTypeBuilder<Client> modelBuilder)
        {
            modelBuilder.Property(c => c.Name).HasMaxLength(100);
            modelBuilder.HasMany(c => c.Cars);
        }

        private static void CarConfiguration(EntityTypeBuilder<Car> modelBuilder)
        {
            modelBuilder.Property(c => c.Model).HasMaxLength(100);
            modelBuilder.Property(c => c.LicensePlate).HasMaxLength(10);
            modelBuilder.HasOne(c => c.Client);
        }
    }
}
