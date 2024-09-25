using Microsoft.EntityFrameworkCore;

namespace Inventory.ReportManagement
{
    public static class ReportContextSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Seeding Reports
            modelBuilder.Entity<Report>().HasData(
                new Report
                {
                    ReportId = 1,
                    Name = "Inventory Report",
                    Description = "Detailed inventory report",
                    ReportType = "Inventory",
                    CreatedAt = DateTime.Now,
                    Parameters = "StartDate, EndDate"
                },
                new Report
                {
                    ReportId = 2,
                    Name = "Sales Report",
                    Description = "Monthly sales report",
                    ReportType = "Sales",
                    CreatedAt = DateTime.Now,
                    Parameters = "Month, Year"
                }
            );

            // Seeding ReportHistories
            modelBuilder.Entity<ReportHistory>().HasData(
                new ReportHistory
                {
                    ReportHistoryId = 1,
                    ReportId = 1,
                    UserId = 1,
                    GeneratedAt = DateTime.Now,
                    ParametersUsed = "StartDate=2023-01-01, EndDate=2023-01-31",
                    ReportLink = "/reports/inventory/2023-01"
                },
                new ReportHistory
                {
                    ReportHistoryId = 2,
                    ReportId = 2,
                    UserId = 2,
                    GeneratedAt = DateTime.Now,
                    ParametersUsed = "Month=01, Year=2023",
                    ReportLink = "/reports/sales/2023-01"
                }
            );
        }
    }
}
