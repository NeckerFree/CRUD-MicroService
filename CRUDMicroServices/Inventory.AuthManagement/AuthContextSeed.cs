using Microsoft.EntityFrameworkCore;

namespace Inventory.AuthManagement
{
    public static class AuthContextSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Seeding Roles with Permissions initialized
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Admin",
                    Description = "Administrator Role",
                    Permissions = new List<Permission>() // Initialize Permissions as an empty list
                },
                new Role
                {
                    Id = 2,
                    Name = "User",
                    Description = "User Role",
                    Permissions = new List<Permission>() // Initialize Permissions as an empty list
                }
            );

            // Seeding Permissions
            modelBuilder.Entity<Permission>().HasData(
                new Permission { Id = 1, Name = "Create", Description = "Create permissions", RoleId = 1 },
                new Permission { Id = 2, Name = "Read", Description = "Read permissions", RoleId = 1 },
                new Permission { Id = 3, Name = "Update", Description = "Update permissions", RoleId = 1 },
                new Permission { Id = 4, Name = "Delete", Description = "Delete permissions", RoleId = 1 },
                new Permission { Id = 5, Name = "Read", Description = "Read permissions", RoleId = 2 }
            );

            // Seeding Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "admin",
                    Email = "admin@example.com",
                    HashPassword = "hashedpassword", // replace with actual hashed password
                    RoleId = 1,
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    LastLogin = DateTime.Now
                },
                new User
                {
                    Id = 2,
                    UserName = "user",
                    Email = "user@example.com",
                    HashPassword = "hashedpassword", // replace with actual hashed password
                    RoleId = 2,
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    LastLogin = DateTime.Now
                }
            );

            // Seeding Addresses
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    AddressId = 1,
                    UserId = 1,
                    Line1 = "123 Admin St",
                    City = "Admin City",
                    State = "Admin State",
                    Country = "Admin Country"
                },
                new Address
                {
                    AddressId = 2,
                    UserId = 2,
                    Line1 = "456 User Ave",
                    City = "User City",
                    State = "User State",
                    Country = "User Country"
                }
            );

            // Seeding UserRoles
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { UserId = 1, RoleId = 1 },
                new UserRole { UserId = 2, RoleId = 2 }
            );
        }
    }

}