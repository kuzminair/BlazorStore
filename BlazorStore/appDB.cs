using BlazorStore.Components.Pages;
using Microsoft.EntityFrameworkCore;

namespace BlazorStore
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        { 
            Database.EnsureCreated(); 
        }

        public DbSet<Item> Items => Set<Item>();
        public DbSet<Order> Orders => Set<Order>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=catalogItems.db");
        }

    }
}
