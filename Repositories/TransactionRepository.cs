using InventoryAPI.Data;
using InventoryAPI.Models;

namespace InventoryAPI.Repositories
{
    public class TransactionRepository
    {
        private readonly InventoryDbContext _context;

        public TransactionRepository(InventoryDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ProcessTransaction(Transaction transaction)
        {
            var product = await _context.Products.FindAsync(transaction.productid);
            if (product == null) return false;

            if (transaction.type == "Compra")
            {
                product.StockQuantity += transaction.quantity;
            }
            else if (transaction.type == "Venta")
            {
                if (product.StockQuantity < transaction.quantity) return false;
                product.StockQuantity -= transaction.quantity;
            }

            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}