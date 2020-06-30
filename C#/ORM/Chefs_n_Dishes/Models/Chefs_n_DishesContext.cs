using Microsoft.EntityFrameworkCore;

namespace Chefs_n_Dishes.Models
{
    public class Chefs_n_DishesContext : DbContext
    {
        public Chefs_n_DishesContext(DbContextOptions options) : base(options) { }
        
        public DbSet<User> Users {get;set;}
        public DbSet<Dish> Dishes {get;set;}
    }
}