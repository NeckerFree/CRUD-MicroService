namespace Inventory.StockManagement
{
    public class StockMovement
    {
        public int StockMovementId { get; set; }
        public int InventoryId { get; set; }
        public string MovementType { get; set; } // E.g., Inbound, Outbound, Adjustment
        public int Quantity { get; set; }
        public DateTime MovementDate { get; set; }
        public string Description { get; set; }
        public int? OrderId { get; set; }
    }

}
