using Microsoft.EntityFrameworkCore;

namespace Hangman.Models { 
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Query> Queries { get; set; }
        public virtual DbSet<Blank_Query> Blank_Queries { get; set;}
        public virtual DbSet<Game> Games { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(
                    "server=localhost//sqlexpress;database=hangman;trusted_connection=true;");
            }

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
