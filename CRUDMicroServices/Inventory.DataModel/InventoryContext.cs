using Microsoft.EntityFrameworkCore;

namespace Inventory.DataModel
{
    public class InventoryContext: DbContext
    {
        public InventoryContext()
        {
                
        }
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-89ED63S7;Initial Catalog=InventoryDb; User Id=AppUser;Password=AppPwd;Encrypt=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            DbContextSeed.Seed(modelBuilder);
        }
      
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ProductWarehouse> ProductWarehouses { get; set; }
    }
}
