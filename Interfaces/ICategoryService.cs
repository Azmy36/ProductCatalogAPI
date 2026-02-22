using Assignment2App.Models;

namespace Assignment2App.Interfaces;

public interface ICategoryService
{
    List<Category> GetAll();
    Category? GetById(int id);
    Category Add(Category category);
}
