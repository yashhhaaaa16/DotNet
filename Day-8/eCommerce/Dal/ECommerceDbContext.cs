﻿using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Dal;

public class ECommerceDbContext : DbContext
{
    public ECommerceDbContext()
    {

    }
    public ECommerceDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products{ get; set; }
    public DbSet<Customer> Customers{ get; set; }
    public DbSet<Cart> Carts{ get; set; }
    public DbSet<CartItem> CartItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("Server=192.168.100.80;PORT=3306;Database=InfowayEComDb;User Id=saleel;Password=saleel", serverVersion);
        }
    }
}
