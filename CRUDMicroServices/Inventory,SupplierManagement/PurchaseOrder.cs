namespace Inventory.SupplierManagement
{
    public class PurchaseOrder
    {
        public int PurchaseOrderId { get; set; }
        public int SupplierId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; } // E.g., Pending, Received, Canceled
        public decimal TotalAmount { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
    }

}
