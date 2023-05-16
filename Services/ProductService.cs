using MyWebApi.Data;
using MyWebApi.Models;

namespace MyWebApi.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository  _productRepository;
    
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        return await _productRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _productRepository.GetAllAsync();
    }
}