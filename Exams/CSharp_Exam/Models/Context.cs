using Microsoft.EntityFrameworkCore;

namespace CSharp_Exam.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<User> Users {get;set;}
        public DbSet<Exercise> Exercises {get;set;}
        public DbSet<Participate> Participates {get;set;}
    }
}