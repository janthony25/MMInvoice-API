using Microsoft.EntityFrameworkCore;
using MMInvoice_API.Models.Entity;

namespace MMInvoice_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<tblCustomer> tblCustomer { get; set; }
        public DbSet<tblCar> tblCar { get; set; }
        public DbSet<tblCarMake> tblCarMake { get; set; }
        public DbSet<tblCarManufacturer> tblCarManufacturer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Customer - Car
            modelBuilder.Entity<tblCustomer>()
                .HasMany(c => c.tblCar)
                .WithOne(ca => ca.tblCustomer)
                .HasForeignKey(ca => ca.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            // many-to-many  Car-CarMake
            modelBuilder.Entity<tblCarManufacturer>()
                .HasKey(cm => new { cm.CarId, cm.CarMakeId });

            modelBuilder.Entity<tblCarManufacturer>()
                .HasOne(cm => cm.tblCar)
                .WithMany(c => c.tblCarManufacturer)
                .HasForeignKey(cm => cm.CarId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<tblCarManufacturer>()
                .HasOne(cm => cm.tblCarMake)
                .WithMany(ca => ca.tblCarManufacturer)
                .HasForeignKey(cm => cm.CarMakeId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
