namespace Inventory.DataModel
{
    public class Supplier
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ContactEmail { get; set; }
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public required string Country { get; set; }


        public ICollection<Product>? Products { get; set; }

    }
}
