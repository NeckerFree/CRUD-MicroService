using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace Inventory.AuthManagement
{
    public class AuthContext: DbContext
    {
        public AuthContext()
        {
            
        }
        public AuthContext(DbContextOptions<AuthContext> options) : base(options)
        {  
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AuthContextSeed.Seed(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=AuthDb;User Id=sa;Password=AppPwd#1234;TrustServerCertificate=True;");
        }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
