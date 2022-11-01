using BackEnd.Context;
using BlazorWAA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var dbPath = builder.Configuration["DbPath"];

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlite(
        $"Data Source={dbPath}"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// "/add_product" - RPC
// "/catalog/products" - REST

app.MapPost("/add_product", 
    async ([FromBody] Product product, 
        [FromServices] AppDbContext dbContext) =>
    {
        await dbContext.Products.AddAsync(product);
        await dbContext.SaveChangesAsync();
    });

app.MapGet("/get_products", 
    async ([FromServices] AppDbContext dbContext) => 
    await dbContext.Products.ToListAsync());

app.MapPost("/get_product",
    async ([FromServices] AppDbContext dbContext,
        [FromQuery] long productId) =>
    await dbContext.Products
    .FirstOrDefaultAsync(p => p.Id == productId));

app.MapPost("/update_product",
    async ([FromServices] AppDbContext dbContext,
        [FromQuery] long productId, string name, decimal price) =>
    {
        var product = await dbContext.Products.FindAsync(productId);
        product!.Name = name;
        product.Price = price;
        dbContext.Products.Update(product!);
        await dbContext.SaveChangesAsync();
    });

app.MapPost("/delete_product",
    async ([FromServices] AppDbContext dbContext,
    [FromQuery] long productId) =>
    {
        var product = await dbContext.Products.FindAsync(productId);
        dbContext.Products.Remove(product!);
        await dbContext.SaveChangesAsync();
    });

app.Run();