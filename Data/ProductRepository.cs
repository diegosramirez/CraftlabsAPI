using MyWebApi.Models;

namespace MyWebApi.Data;

public class ProductRepository : IProductRepository
{
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Test",
            },
            new Product
            {
                Id = 2,
                Name = "Test 2",
            },
            new Product
            {
                Id = 3,
                Name = "Test 3",
            },
            new Product
            {
                Id = 3,
                Name = "Test 4",
            }
        };
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        return new Product
        {
            Id = id,
            Name = $"Product with ID = {id}",
        };
    }
}