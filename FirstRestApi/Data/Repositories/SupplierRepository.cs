using Business.Interfaces;
using FirstRestAPI.Context;
using FirstRestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class SupplierRepository : Repository<Supplier>, ISupplierRepository
{
    public SupplierRepository(ApiDbContext context) : base(context)
    {
    }

    public async Task<Supplier?> GetSupplierAddress(Guid id)
    {
        return await Db.Suppliers.AsNoTracking()
            .Include(s => s.Address)
            .FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<Supplier?> GetSupplierProductAddress(Guid id)
    {
        return await Db.Suppliers.AsNoTracking()
            .Include(s => s.Address)
            .Include(s => s.Products)
            .FirstOrDefaultAsync(s => s.Id == id);
    }
}
