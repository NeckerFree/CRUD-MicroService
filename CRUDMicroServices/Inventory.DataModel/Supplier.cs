namespace Inventory.DataModel
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactEmail { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        // Relación con Product (uno a muchos)
        public ICollection<Product> Products { get; set; } // Un proveedor puede suministrar muchos productos
    }

}
