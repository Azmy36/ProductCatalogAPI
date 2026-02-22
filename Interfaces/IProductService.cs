using Assignment2App.Models;

namespace Assignment2App.Interfaces;

public interface IProductService
{
    List<Product> GetAll();
    Product? GetById(int id);
    Product Add(Product product);
}
