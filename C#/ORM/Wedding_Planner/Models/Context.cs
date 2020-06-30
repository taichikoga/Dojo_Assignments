using Microsoft.EntityFrameworkCore;

namespace Wedding_Planner.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<User> Users {get;set;}
        public DbSet<Wedding> Weddings {get;set;}
        public DbSet<Attend> Attends {get;set;}
    }
}