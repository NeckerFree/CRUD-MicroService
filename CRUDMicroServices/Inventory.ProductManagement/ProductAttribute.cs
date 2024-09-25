namespace Inventory.ProductManagement
{
    public class ProductAttribute
    {
        public int ProductAttributeId { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; } // E.g., text, number, list
    }

}
