using Microsoft.EntityFrameworkCore;

namespace Inventory.ProductManagement
{
    public static class ProductContextSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Seeding Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Electronics", Description = "Electronic items" },
                new Category { CategoryId = 2, Name = "Clothing", Description = "Apparel and accessories" }
            );

            // Seeding Brands
            modelBuilder.Entity<Brand>().HasData(
                new Brand { BrandId = 1, Name = "BrandA", Description = "Brand A Description" },
                new Brand { BrandId = 2, Name = "BrandB", Description = "Brand B Description" }
            );

            // Seeding Products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Laptop",
                    Description = "High performance laptop",
                    SKU = "LAP123",
                    Price = 999.99m,
                    CategoryId = 1,
                    BrandId = 1,
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Product
                {
                    ProductId = 2,
                    Name = "T-Shirt",
                    Description = "Comfortable cotton t-shirt",
                    SKU = "TSH123",
                    Price = 19.99m,
                    CategoryId = 2,
                    BrandId = 2,
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );

            // Seeding ProductAttributes
            modelBuilder.Entity<ProductAttribute>().HasData(
                new ProductAttribute { ProductAttributeId = 1, Name = "Color", Type = "text" },
                new ProductAttribute { ProductAttributeId = 2, Name = "Size", Type = "text" }
            );

            // Seeding AttributeValues
            modelBuilder.Entity<AttributeValue>().HasData(
                new AttributeValue { AttributeValueId = 1, ProductId = 1, ProductAttributeId = 1, Value = "Silver" },
                new AttributeValue { AttributeValueId = 2, ProductId = 2, ProductAttributeId = 2, Value = "Large" }
            );
        }
    }
}
