using MyWebApi.Models;

namespace MyWebApi.Services;

public interface IProductService
{
    Task<Product?> GetByIdAsync(int id);
    Task<IEnumerable<Product>> GetAllAsync();
}