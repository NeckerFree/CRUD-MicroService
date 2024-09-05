using Microsoft.EntityFrameworkCore;

namespace Inventory.AuthManagement
{
    internal class AuthContext: DbContext
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
            optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=InventoryDb; User Id=AppUser;Password=AppPwd;Encrypt=False;");
        }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
