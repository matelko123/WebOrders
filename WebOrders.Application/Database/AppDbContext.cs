using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WebOrders.Application.Entities;

namespace WebOrders.Application.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }

    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductOrder> ProductOrders { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<ProductOrder>()
            .HasOne(po => po.Product);

        modelBuilder.Entity<Order>()
            .HasMany(o => o.ProductOrders)
            .WithOne(po => po.Order);
        
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}