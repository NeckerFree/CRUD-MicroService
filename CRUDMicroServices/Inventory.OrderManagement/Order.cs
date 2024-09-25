namespace OrderManagement
{
    // Entities for the Order Service

    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime CreatedAt { get; set; }
        public required string Status { get; set; }  // pending, processed, completed, cancelled
        public decimal Total { get; set; }
        public required string PaymentMethod { get; set; }
        public required string ShippingAddress { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
