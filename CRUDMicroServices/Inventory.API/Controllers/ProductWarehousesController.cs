using Inventory.DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductWarehousesController : ControllerBase
    {
        private readonly InventoryContext _context;

        public ProductWarehousesController(InventoryContext context)
        {
            _context = context;
        }

        // GET: api/ProductWarehouses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductWarehouse>>> GetProductWarehouses()
        {
            return await _context.ProductWarehouses.ToListAsync();
        }

        // GET: api/ProductWarehouses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductWarehouse>> GetProductWarehouse(int id)
        {
            var productWarehouse = await _context.ProductWarehouses.FindAsync(id);

            if (productWarehouse == null)
            {
                return NotFound();
            }

            return productWarehouse;
        }

        // PUT: api/ProductWarehouses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductWarehouse(int id, ProductWarehouse productWarehouse)
        {
            if (id != productWarehouse.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(productWarehouse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductWarehouseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductWarehouses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductWarehouse>> PostProductWarehouse(ProductWarehouse productWarehouse)
        {
            _context.ProductWarehouses.Add(productWarehouse);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProductWarehouseExists(productWarehouse.ProductId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProductWarehouse", new { id = productWarehouse.ProductId }, productWarehouse);
        }

        // DELETE: api/ProductWarehouses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductWarehouse(int id)
        {
            var productWarehouse = await _context.ProductWarehouses.FindAsync(id);
            if (productWarehouse == null)
            {
                return NotFound();
            }

            _context.ProductWarehouses.Remove(productWarehouse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductWarehouseExists(int id)
        {
            return _context.ProductWarehouses.Any(e => e.ProductId == id);
        }
    }
}
