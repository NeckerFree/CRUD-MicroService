namespace OrderManagement
{
    public class Payment
    {
        public int ID { get; set; }
        public int OrderID { get; set; }  // Foreign key to Order
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public required string PaymentMethod { get; set; }  // card, transfer, etc.
        public required string PaymentStatus { get; set; }  // completed, pending, failed
    }
}
