using System.ComponentModel.DataAnnotations;

namespace BlazorWAA.Models;

public class Product
{
    public Product(long id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    [Required]
    public long Id { get; set; }
    [Required, MinLength(3)]
    public string Name { get; set; }
    [Required]
    public decimal Price { get; set; }
}