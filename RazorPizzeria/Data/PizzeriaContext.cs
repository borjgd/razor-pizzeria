using RazorPizzeria.Models;
using Microsoft.EntityFrameworkCore;

namespace RazorPizzeria.Data
{
    public class PizzeriaContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<FoodItems> FoodItems { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<FoodCategories> FoodCategories { get; set; }
        public PizzeriaContext(DbContextOptions<PizzeriaContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Temp\Pizzeria.db");
        }


    }
}
