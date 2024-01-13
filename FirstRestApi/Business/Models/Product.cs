using FirstRestAPI.Models;

namespace Business.Models;

public class Product : Entity
{
    public Guid SupplierId { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Image {  get; set; } = string.Empty;
    public decimal Value {  get; set; }
    public DateTime CreatedAt {  get; set; }
    public bool IsActive {  get; set; }

    public Supplier? Supplier { get; set; }
}
