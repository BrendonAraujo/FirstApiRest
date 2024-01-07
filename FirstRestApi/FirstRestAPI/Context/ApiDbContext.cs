// Ignore Spelling: Api

using FirstRestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstRestAPI.Context;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions options) : base(options) 
    {
    }

    public DbSet<Supplier> Suppliers { get; set; }
}
