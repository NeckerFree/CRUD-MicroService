using Microsoft.EntityFrameworkCore;

namespace Inventory.DataModel
{
    public class InventoryContext: DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ProductWarehouse> ProductWarehouses { get; set; }
    }
}
