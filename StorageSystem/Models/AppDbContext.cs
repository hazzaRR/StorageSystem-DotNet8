using Microsoft.EntityFrameworkCore;

namespace StorageSystem.Models
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<StorageBin> StorageBin { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Item> Item { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ItemStorageBin>()
                .HasKey(isb => new { isb.ItemId, isb.StorageBinId });
        }
    }
}
