using Business.Interfaces;
using Business.Models;
using FirstRestAPI.Context;

namespace Data.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(ApiDbContext context) : base(context)
    {
    }
}
