using Gametopia.GameStorage.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gametopia.GameStorage.Configuration
{
    public class GameStorageDbContext : DbContext
    {
        public GameStorageDbContext(DbContextOptions<GameStorageDbContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>()
                .ToTable("Games");
            modelBuilder.Entity<Game>()
                .HasKey(e => e.Id);
        }
    }
}
