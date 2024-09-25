namespace Inventory.ProductManagement
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public required string Description { get; set; }
        public string? SKU { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
