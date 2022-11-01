using BlazorWAA.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Context;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
    
    public AppDbContext(
        DbContextOptions<AppDbContext> options)
    : base(options) { }
}