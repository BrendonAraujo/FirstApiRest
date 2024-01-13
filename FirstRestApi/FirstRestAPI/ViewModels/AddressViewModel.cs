using FirstRestAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace FirstRestAPI.ViewModels;

public class AddressViewModel
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(200, ErrorMessage = "The field {0} need more than {2} and less than {1} characters", MinimumLength = 1)]
    public string Street { get; set; }

    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(500, ErrorMessage = "The field {0} need more than {2} and less than {1} characters", MinimumLength = 1)]
    public string Number { get; set; } = string.Empty;

    public string Complement { get; set; } = string.Empty;

    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(100, ErrorMessage = "The field {0} need more than {2} and less than {1} characters", MinimumLength = 1)]
    public string Neighborhood { get; set; } = string.Empty;

    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(8, ErrorMessage = "The field {0} need more than {2} and less than {1} characters", MinimumLength = 8)]
    public string ZipCode { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(100, ErrorMessage = "The field {0} need more than {2} and less than {1} characters", MinimumLength = 1)]
    public string State { get; set; } = string.Empty;

    public SupplierViewModel? Supplier { get; set; }


}
