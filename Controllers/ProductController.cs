using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;
using MyWebApi.Services;

namespace MyWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute]int id)
    {
        var product = await _productService.GetByIdAsync(id);

        if (product is null)
        {
            return NotFound();
        }
        
        return Ok(product);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _productService.GetAllAsync();
        
        return Ok(products);
    }
    
}