namespace Inventory.OrderManagement
{
    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
    }

}
