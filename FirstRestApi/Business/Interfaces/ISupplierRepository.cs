﻿using FirstRestAPI.Models;

namespace Business.Interfaces;

public interface ISupplierRepository : IRepository<Supplier>
{
    Task<Supplier?> GetSupplierAddress(Guid id);
    Task<Supplier?> GetSupplierProductAddress(Guid id);
}
