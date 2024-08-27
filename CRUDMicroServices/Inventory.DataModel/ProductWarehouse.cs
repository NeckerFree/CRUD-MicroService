namespace Inventory.DataModel
{
    // Clase intermedia para la relación muchos a muchos entre Product y Warehouse
    public class ProductWarehouse
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }

}
