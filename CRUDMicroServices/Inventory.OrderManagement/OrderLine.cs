namespace OrderManagement
{
    public class OrderLine
    {
        public int ID { get; set; }
        public int OrderID { get; set; }  // Foreign key to Order
        public int ProductID { get; set; }  // Foreign key to Product
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
    }
}
