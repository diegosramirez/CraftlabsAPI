using MyWebApi.Models;

namespace MyWebApi.Data;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();

    Task<Product> GetByIdAsync(int id);
}