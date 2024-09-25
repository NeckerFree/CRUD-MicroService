using Microsoft.EntityFrameworkCore;
using System;

namespace OrderManagement
{
    public static class OrderContextSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Seeding Orders
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    ID = 1,
                    CustomerID = 101,
                    CreatedAt = DateTime.Now.AddDays(-5),
                    Status = "completed",
                    Total = 150.75m,
                    PaymentMethod = "card",
                    ShippingAddress = "123 Main St, Cityville",
                    ShippingDate = DateTime.Now.AddDays(-3),
                    DeliveryDate = DateTime.Now.AddDays(-1)
                },
                new Order
                {
                    ID = 2,
                    CustomerID = 102,
                    CreatedAt = DateTime.Now.AddDays(-2),
                    Status = "pending",
                    Total = 250.50m,
                    PaymentMethod = "transfer",
                    ShippingAddress = "456 Oak St, Townsville"
                }
            );

            // Seeding OrderLines
            modelBuilder.Entity<OrderLine>().HasData(
                new OrderLine
                {
                    ID = 1,
                    OrderID = 1,
                    ProductID = 201,
                    Quantity = 2,
                    UnitPrice = 50.25m,
                    Total = 100.50m
                },
                new OrderLine
                {
                    ID = 2,
                    OrderID = 1,
                    ProductID = 202,
                    Quantity = 1,
                    UnitPrice = 50.25m,
                    Total = 50.25m
                },
                new OrderLine
                {
                    ID = 3,
                    OrderID = 2,
                    ProductID = 203,
                    Quantity = 5,
                    UnitPrice = 50.10m,
                    Total = 250.50m
                }
            );

            // Seeding Payments
            modelBuilder.Entity<Payment>().HasData(
                new Payment
                {
                    ID = 1,
                    OrderID = 1,
                    Amount = 150.75m,
                    PaymentDate = DateTime.Now.AddDays(-4),
                    PaymentMethod = "card",
                    PaymentStatus = "completed"
                },
                new Payment
                {
                    ID = 2,
                    OrderID = 2,
                    Amount = 250.50m,
                    PaymentDate = DateTime.Now,
                    PaymentMethod = "transfer",
                    PaymentStatus = "pending"
                }
            );
        }
    }
}
