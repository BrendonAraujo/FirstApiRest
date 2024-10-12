// Ignore Spelling: Api

using Business.Models;
using Data.Mappings;
using FirstRestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstRestAPI.Context;

public class ApiDbContext : DbContext
{
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Address> Addresses { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration<Supplier>(new SupplierMapping());
        modelBuilder.ApplyConfiguration<Address>(new AddressMapping());
        modelBuilder.ApplyConfiguration<Product>(new ProductMapping());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Server=tcp:localhost:1433;Initial Catalog=control;Persist Security Info=False;User ID=sa;Password=DockerSQL192!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
        );

        base.OnConfiguring(options);
    }
}
