using Microsoft.EntityFrameworkCore;

namespace Products_and_Categories.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Association> Associations {get;set;}
    }
}