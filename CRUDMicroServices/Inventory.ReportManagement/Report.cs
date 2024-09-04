namespace Inventory.ReportManagement
{
    public class Report
    {
        public int ReportId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ReportType { get; set; } // E.g., Inventory, Sales, Purchases
        public DateTime CreatedAt { get; set; }
        public string Parameters { get; set; }
    }

}
