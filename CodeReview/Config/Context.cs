using CodeReview.Entity;
using Microsoft.EntityFrameworkCore;

namespace CodeReview.Config
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(x => x.Id)
                .IsRequired();
        }
    }
}
