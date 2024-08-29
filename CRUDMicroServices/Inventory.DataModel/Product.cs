namespace Inventory.DataModel
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
     
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public int SupplierId { get; set; }
        public ICollection<ProductWarehouse>? ProductWarehouses { get; set; } // Un producto puede estar en muchos almacenes
    }

}
