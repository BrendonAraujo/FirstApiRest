using FirstRestAPI.Models;

namespace Business.Models;

public class Address : Entity
{
    public Guid SupplierId { get; set; }
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string Complement {  get; set; } = string.Empty;
    public string ZipCode {  get; set; } = string.Empty;
    public string Neighborhood {  get; set; } = string.Empty;
    public string State {  get; set; } = string.Empty;
    
    public Supplier? Supplier { get; set; }
}
