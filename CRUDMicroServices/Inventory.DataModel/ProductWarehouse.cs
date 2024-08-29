using Microsoft.EntityFrameworkCore;

namespace Inventory.DataModel
{
    [PrimaryKey(nameof(ProductId), nameof(WarehouseId))]
    public class ProductWarehouse
    {
        public int ProductId { get; set; }

        public int WarehouseId { get; set; }

    }

}
