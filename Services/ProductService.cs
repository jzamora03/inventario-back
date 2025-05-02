using InventoryAPI.Repositories;
using InventoryAPI.Models;

namespace InventoryAPI.Services
{
    public class ProductService
    {
        private readonly ProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Product>> GetAllProducts() => _repository.GetAllAsync();
        public Task<Product?> GetProductById(int id) => _repository.GetByIdAsync(id);
        public Task AddProduct(Product product) => _repository.AddAsync(product);
        public Task UpdateProduct(Product product) => _repository.UpdateAsync(product);
        public Task DeleteProduct(int id) => _repository.DeleteAsync(id);
    }
}