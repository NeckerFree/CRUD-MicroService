namespace Inventory.SupplierManagement
{

    public class PurchaseOrderLine
    {
        public int PurchaseOrderLineId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
    }

}
