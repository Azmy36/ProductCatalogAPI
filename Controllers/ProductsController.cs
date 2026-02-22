using Microsoft.AspNetCore.Mvc;
using Assignment2App.Interfaces;
using Assignment2App.Models;

namespace Assignment2App.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    /// <summary>Endpoint 1: Get all products</summary>
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_productService.GetAll());
    }

    /// <summary>Endpoint 2: Get product by id</summary>
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = _productService.GetById(id);
        if (product == null)
            return NotFound();
        return Ok(product);
    }

    /// <summary>Endpoint 3: Add new product</summary>
    [HttpPost]
    public IActionResult Add(Product product)
    {
        return Ok(_productService.Add(product));
    }
}
