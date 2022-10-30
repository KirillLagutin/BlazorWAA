using BlazorWAA.Models;

namespace BlazorWAA.Data;

public static class Cart
{
    public static readonly List<Product?>? Products = new();
    
    
    public static void AddToCart(Product product)
    {
        Products?.Add(product);
    }
    public static void DeleteFromCart(Product product)
    {
        Products!.Remove(product);
    }
    public static void ClearCart()
    {
        Products!.Clear();
    }
}