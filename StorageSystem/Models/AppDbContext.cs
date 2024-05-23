using Microsoft.EntityFrameworkCore;

namespace StorageSystem.Models
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<StorageBin> StorageBin { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemStorageBin> ItemStorageBin { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Location>()
                .HasKey(l => l.Id);

            modelBuilder.Entity<StorageBin>()
                .HasKey(sb => sb.Id);

            modelBuilder.Entity<Item>()
                .HasKey(i => i.Id);

            modelBuilder.Entity<ItemStorageBin>()
                .HasKey(isb => new { isb.ItemId, isb.StorageBinId });
        }
    }
}
