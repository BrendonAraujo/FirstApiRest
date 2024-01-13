using System.ComponentModel.DataAnnotations;

namespace FirstRestAPI.ViewModels;

public class SupplierViewModel
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(100, ErrorMessage = "The field {0} need more than {2} and less than {1} characters", MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;


    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(14, ErrorMessage = "The field {0} need more than {2} and less than {1} characters", MinimumLength = 11)]
    public string Document { get; set; } = string.Empty;
    
    public int SupplierType { get; set; }

    public AddressViewModel? Address {  get; set; }

    public bool IsActive { get; set; }

    public IEnumerable<ProductViewModel> Products { get; set; } = Enumerable.Empty<ProductViewModel>();

}