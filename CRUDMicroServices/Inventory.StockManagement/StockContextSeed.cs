using Microsoft.EntityFrameworkCore;

namespace Inventory.StockManagement
{
    public static class StockContextSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Seeding Locations
            modelBuilder.Entity<Location>().HasData(
                new Location { LocationId = 1, Name = "Main Warehouse", Description = "Primary storage location", Address = "123 Main St" },
                new Location { LocationId = 2, Name = "Secondary Warehouse", Description = "Secondary storage location", Address = "456 Secondary St" }
            );

            // Seeding Inventories
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory
                {
                    InventoryId = 1,
                    ProductId = 1,
                    AvailableQuantity = 100,
                    ReservedQuantity = 10,
                    LocationId = 1
                },
                new Inventory
                {
                    InventoryId = 2,
                    ProductId = 2,
                    AvailableQuantity = 50,
                    ReservedQuantity = 5,
                    LocationId = 2
                }
            );

            // Seeding StockMovements
            modelBuilder.Entity<StockMovement>().HasData(
                new StockMovement
                {
                    StockMovementId = 1,
                    InventoryId = 1,
                    MovementType = "Inbound",
                    Quantity = 100,
                    MovementDate = DateTime.Now,
                    Description = "Initial stock",
                    OrderId = null
                },
                new StockMovement
                {
                    StockMovementId = 2,
                    InventoryId = 2,
                    MovementType = "Inbound",
                    Quantity = 50,
                    MovementDate = DateTime.Now,
                    Description = "Initial stock",
                    OrderId = null
                }
            );
        }
    }
}
