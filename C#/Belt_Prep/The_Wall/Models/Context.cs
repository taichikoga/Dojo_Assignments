using Microsoft.EntityFrameworkCore;

namespace The_Wall.Models
{
    public class Context : DbContext
    {
    public Context(DbContextOptions options) : base(options) { }

    // for every model / entity that is going to be part of the db
    // the names of these properties will be the names of the tables in the db
    public DbSet<User> Users { get; set; }

    public DbSet<Message> Messages {get;set;}

    public DbSet<Comment> Comments {get;set;}
    }
}