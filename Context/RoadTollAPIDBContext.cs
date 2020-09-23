using Microsoft.EntityFrameworkCore;
using RoadTollAPI.Entities;


namespace RoadTollAPI.Context
{
    public class RoadTollAPIDBContext : DbContext
    {
        public DbSet<Owner> Owners { set; get; }
        public DbSet<Car> Cars { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=RoadTollAPI;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>()
                .HasOne<Car>(o => o.car)
                .WithOne(c => c.owner)
                .HasForeignKey<Car>(c => c.CarOfOwnerId);
        }
    }
}
