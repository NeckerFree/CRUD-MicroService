namespace Inventory.OrderManagement
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; } // E.g., Pending, Processed, Completed, Canceled
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime? ShippedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
    }

}
