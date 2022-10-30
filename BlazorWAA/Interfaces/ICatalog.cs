using BlazorWAA.Models;

namespace BlazorWAA.Interfaces;

public interface ICatalog
{
    IReadOnlyList<Product> GetProducts();
    void AddProduct(Product product);
}