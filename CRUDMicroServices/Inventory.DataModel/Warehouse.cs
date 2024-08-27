namespace Inventory.DataModel
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string Manager { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }

        // Relación muchos a muchos con Product
        public ICollection<ProductWarehouse> ProductWarehouses { get; set; } // Un almacén puede almacenar muchos productos
    }

}
