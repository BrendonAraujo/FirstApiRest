using FirstRestAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace FirstRestAPI.ViewModels;

public class ProductViewModel
{
    [Key]
    public Guid Id {  get; set; }
    public Guid SupplierId { get; set; }

    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(200, ErrorMessage = "The field {0} need more than {2} and less than {1} characters", MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "The field {0} is required")]
    [StringLength(1000, ErrorMessage = "The field {0} need more than {2} and less than {1} characters", MinimumLength = 2)]
    public string Description { get; set; } = string.Empty;

    public string UploadImagem { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;

    [Required(ErrorMessage = "The field {0} is required")]
    public decimal Value { get; set; }

    [ScaffoldColumn(false)]
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }

    [ScaffoldColumn(false)]
    public string? SupplierName { get; set; }
}
