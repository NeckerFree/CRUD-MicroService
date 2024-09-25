using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Inventory.ReportManagement
{
    public class ReportContext : DbContext
    {
        public ReportContext()
        {
        }

        public ReportContext(DbContextOptions<ReportContext> options) : base(options)
        {
            try
            {
                var dbCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (dbCreator != null)
                {
                    if (!dbCreator.CanConnect())
                        dbCreator.Create();
                    if (!dbCreator.HasTables())
                        dbCreator.CreateTables();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ReportContextSeed.Seed(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=sqlserverinventory;Database=ReportDb;User Id=sa;Password=AppPwd*1234;TrustServerCertificate=True;");
        }

        public DbSet<Report> Reports { get; set; }
        public DbSet<ReportHistory> ReportHistories { get; set; }
    }
}
