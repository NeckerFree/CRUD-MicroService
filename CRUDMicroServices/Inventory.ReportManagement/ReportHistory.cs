namespace Inventory.ReportManagement
{

    public class ReportHistory
    {
        public int ReportHistoryId { get; set; }
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public DateTime GeneratedAt { get; set; }
        public string ParametersUsed { get; set; }
        public string ReportLink { get; set; } // Link or reference to the generated report file
    }

}
