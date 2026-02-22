using Assignment2App.Interfaces;
using Assignment2App.Models;

namespace Assignment2App.Services;

public class CategoryService : ICategoryService
{
    private static readonly List<Category> _categories = new();
    private static int _nextId = 1;

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category? GetById(int id)
    {
        return _categories.FirstOrDefault(c => c.Id == id);
    }

    public Category Add(Category category)
    {
        category.Id = _nextId++;
        _categories.Add(category);
        return category;
    }
}
