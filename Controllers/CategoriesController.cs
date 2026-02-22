using Microsoft.AspNetCore.Mvc;
using Assignment2App.Interfaces;
using Assignment2App.Models;

namespace Assignment2App.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    /// <summary>Endpoint 1: Get all categories</summary>
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_categoryService.GetAll());
    }

    /// <summary>Endpoint 2: Get category by id</summary>
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var category = _categoryService.GetById(id);
        if (category == null)
            return NotFound();
        return Ok(category);
    }

    /// <summary>Endpoint 3: Add new category</summary>
    [HttpPost]
    public IActionResult Add(Category category)
    {
        return Ok(_categoryService.Add(category));
    }
}
