using Microsoft.EntityFrameworkCore;

namespace Inventory.SupplierManagement
{
    public static class SupplierContextSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Seeding Suppliers
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    SupplierId = 1,
                    Name = "Supplier A",
                    ContactName = "John Doe",
                    ContactEmail = "john.doe@suppliera.com",
                    ContactPhone = "123-456-7890",
                    Address = "123 Supplier St",
                    IsActive = true
                },
                new Supplier
                {
                    SupplierId = 2,
                    Name = "Supplier B",
                    ContactName = "Jane Smith",
                    ContactEmail = "jane.smith@supplierb.com",
                    ContactPhone = "098-765-4321",
                    Address = "456 Supplier Ave",
                    IsActive = true
                }
            );

            // Seeding PurchaseOrders
            modelBuilder.Entity<PurchaseOrder>().HasData(
                new PurchaseOrder
                {
                    PurchaseOrderId = 1,
                    SupplierId = 1,
                    CreatedAt = DateTime.Now,
                    Status = "Pending",
                    TotalAmount = 1000.00m,
                    ExpectedDeliveryDate = DateTime.Now.AddDays(7)
                },
                new PurchaseOrder
                {
                    PurchaseOrderId = 2,
                    SupplierId = 2,
                    CreatedAt = DateTime.Now,
                    Status = "Pending",
                    TotalAmount = 500.00m,
                    ExpectedDeliveryDate = DateTime.Now.AddDays(7)
                }
            );

            // Seeding PurchaseOrderLines
            modelBuilder.Entity<PurchaseOrderLine>().HasData(
                new PurchaseOrderLine
                {
                    PurchaseOrderLineId = 1,
                    PurchaseOrderId = 1,
                    ProductId = 1,
                    Quantity = 10,
                    UnitPrice = 100.00m,
                    Total = 1000.00m
                },
                new PurchaseOrderLine
                {
                    PurchaseOrderLineId = 2,
                    PurchaseOrderId = 2,
                    ProductId = 2,
                    Quantity = 5,
                    UnitPrice = 100.00m,
                    Total = 500.00m
                }
            );
        }
    }
}

