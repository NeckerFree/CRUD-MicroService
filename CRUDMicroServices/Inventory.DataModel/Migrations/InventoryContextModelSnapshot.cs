﻿// <auto-generated />
using Inventory.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory.DataModel.Migrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inventory.DataModel.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description for Product One",
                            Name = "Product One",
                            Price = 19.99m,
                            StockQuantity = 100,
                            SupplierId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description for Product Two",
                            Name = "Product Two",
                            Price = 29.99m,
                            StockQuantity = 200,
                            SupplierId = 2
                        });
                });

            modelBuilder.Entity("Inventory.DataModel.ProductWarehouse", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "WarehouseId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("ProductWarehouses");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            WarehouseId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            WarehouseId = 2
                        });
                });

            modelBuilder.Entity("Inventory.DataModel.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St, Cityville",
                            ContactEmail = "supplier1@example.com",
                            Country = "USA",
                            Name = "Supplier One",
                            Phone = "123-456-7890"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Side St, Townsville",
                            ContactEmail = "supplier2@example.com",
                            Country = "Canada",
                            Name = "Supplier Two",
                            Phone = "098-765-4321"
                        });
                });

            modelBuilder.Entity("Inventory.DataModel.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 500,
                            IsActive = true,
                            Location = "Warehouse Location 1",
                            Manager = "Manager One",
                            Phone = "111-222-3333"
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 300,
                            IsActive = true,
                            Location = "Warehouse Location 2",
                            Manager = "Manager Two",
                            Phone = "444-555-6666"
                        });
                });

            modelBuilder.Entity("Inventory.DataModel.Product", b =>
                {
                    b.HasOne("Inventory.DataModel.Supplier", null)
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inventory.DataModel.ProductWarehouse", b =>
                {
                    b.HasOne("Inventory.DataModel.Product", null)
                        .WithMany("ProductWarehouses")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.DataModel.Warehouse", null)
                        .WithMany("ProductWarehouses")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inventory.DataModel.Product", b =>
                {
                    b.Navigation("ProductWarehouses");
                });

            modelBuilder.Entity("Inventory.DataModel.Supplier", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Inventory.DataModel.Warehouse", b =>
                {
                    b.Navigation("ProductWarehouses");
                });
#pragma warning restore 612, 618
        }
    }
}
