using Business.Interfaces;
using Business.Models;
using FirstRestAPI.Context;
using FirstRestAPI.Models;

namespace Data.Repositories;

public class AddressRepository : Repository<Address>, IAddressRepository
{
    public AddressRepository(ApiDbContext context) : base(context)
    {
    }
}
