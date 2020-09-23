using Microsoft.EntityFrameworkCore;
using RoadTollAPI.Entities;


namespace RoadTollAPI.Context
{
    public class RoadTollAPIDBContext : DbContext
    {
        public DbSet<Owner> Owners { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=RoadTollAPI;Trusted_Connection=True;");
        }
    }
}
