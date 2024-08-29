namespace Inventory.DataModel
{
    using Microsoft.EntityFrameworkCore;

    public class DbContextSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Seed Suppliers
            var supplier1 = new Supplier
            {
                Id = 1,
                Name = "Supplier One",
                ContactEmail = "supplier1@example.com",
                Phone = "123-456-7890",
                Address = "123 Main St, Cityville",
                Country = "USA"
            };

            var supplier2 = new Supplier
            {
                Id = 2,
                Name = "Supplier Two",
                ContactEmail = "supplier2@example.com",
                Phone = "098-765-4321",
                Address = "456 Side St, Townsville",
                Country = "Canada"
            };

            // Seed Warehouses
            var warehouse1 = new Warehouse
            {
                Id = 1,
                Location = "Warehouse Location 1",
                Capacity = 500,
                Manager = "Manager One",
                Phone = "111-222-3333",
                IsActive = true
            };

            var warehouse2 = new Warehouse
            {
                Id = 2,
                Location = "Warehouse Location 2",
                Capacity = 300,
                Manager = "Manager Two",
                Phone = "444-555-6666",
                IsActive = true
            };

            // Seed Products without setting the navigation properties
            var product1 = new Product
            {
                Id = 1,
                Name = "Product One",
                Description = "Description for Product One",
                Price = 19.99m,
                StockQuantity = 100,
                SupplierId = 1 // Only set the foreign key
            };

            var product2 = new Product
            {
                Id = 2,
                Name = "Product Two",
                Description = "Description for Product Two",
                Price = 29.99m,
                StockQuantity = 200,
                SupplierId = 2 // Only set the foreign key
            };

            // Seed ProductWarehouses without setting the navigation properties
            var productWarehouse1 = new ProductWarehouse
            {
                ProductId = 1,
                WarehouseId = 1 // Only set the foreign keys
            };

            var productWarehouse2 = new ProductWarehouse
            {
                ProductId = 2,
                WarehouseId = 2 // Only set the foreign keys
            };

            // Configure entity relationships and data
            modelBuilder.Entity<Supplier>().HasData(supplier1, supplier2);
            modelBuilder.Entity<Warehouse>().HasData(warehouse1, warehouse2);
            modelBuilder.Entity<Product>().HasData(product1, product2);
            modelBuilder.Entity<ProductWarehouse>().HasData(productWarehouse1, productWarehouse2);
        }
    }
}