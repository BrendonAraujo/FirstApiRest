using Business.Enuns;
using Business.Models;
using System.ComponentModel.DataAnnotations;

namespace FirstRestAPI.Models;

public class Supplier : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Document { get; set; } = string.Empty;
    public SupplierType Type{ get; set; }
    public Address? Address{ get; set; }
    public bool IsActive { get; set; }

    public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();
}
