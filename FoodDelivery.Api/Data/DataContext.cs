using FoodDelivery.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Api.Data
{
    public partial class DataContext : DbContext
    {
        public const string ConnectionStringName = "FoodDelivery";
        public DataContext():base()
        {
        }
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Offer> Offers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);                        
            SeedData(modelBuilder);
        }
    }
}
