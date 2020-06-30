using Microsoft.EntityFrameworkCore;
using FirstEntityFrameworkProj.Models;

namespace FirstEntityFrameworkProj.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
    }
}