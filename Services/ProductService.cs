using Assignment2App.Interfaces;
using Assignment2App.Models;

namespace Assignment2App.Services;

public class ProductService : IProductService
{
    private static readonly List<Product> _products = new();
    private static int _nextId = 1;

    public List<Product> GetAll()
    {
        return _products;
    }

    public Product? GetById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }

    public Product Add(Product product)
    {
        product.Id = _nextId++;
        _products.Add(product);
        return product;
    }
}
