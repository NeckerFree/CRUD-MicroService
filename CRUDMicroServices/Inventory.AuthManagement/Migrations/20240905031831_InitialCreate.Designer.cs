﻿// <auto-generated />
using System;
using Inventory.AuthManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory.AuthManagement.Migrations
{
    [DbContext(typeof(AuthContext))]
    [Migration("20240905031831_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inventory.AuthManagement.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            City = "Admin City",
                            Country = "Admin Country",
                            Line1 = "123 Admin St",
                            State = "Admin State",
                            UserId = 1
                        },
                        new
                        {
                            AddressId = 2,
                            City = "User City",
                            Country = "User Country",
                            Line1 = "456 User Ave",
                            State = "User State",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Inventory.AuthManagement.Permission", b =>
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

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Create permissions",
                            Name = "Create",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Read permissions",
                            Name = "Read",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Update permissions",
                            Name = "Update",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Delete permissions",
                            Name = "Delete",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Read permissions",
                            Name = "Read",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("Inventory.AuthManagement.Role", b =>
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

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Administrator Role",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Description = "User Role",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Inventory.AuthManagement.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 4, 22, 18, 30, 680, DateTimeKind.Local).AddTicks(2692),
                            Email = "admin@example.com",
                            HashPassword = "hashedpassword",
                            IsActive = true,
                            LastLogin = new DateTime(2024, 9, 4, 22, 18, 30, 680, DateTimeKind.Local).AddTicks(2701),
                            RoleId = 1,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 4, 22, 18, 30, 680, DateTimeKind.Local).AddTicks(2703),
                            Email = "user@example.com",
                            HashPassword = "hashedpassword",
                            IsActive = true,
                            LastLogin = new DateTime(2024, 9, 4, 22, 18, 30, 680, DateTimeKind.Local).AddTicks(2704),
                            RoleId = 2,
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("Inventory.AuthManagement.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("Inventory.AuthManagement.Permission", b =>
                {
                    b.HasOne("Inventory.AuthManagement.Role", null)
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inventory.AuthManagement.Role", b =>
                {
                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
