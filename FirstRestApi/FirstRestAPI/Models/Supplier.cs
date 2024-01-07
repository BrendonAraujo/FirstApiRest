using System.ComponentModel.DataAnnotations;

namespace FirstRestAPI.Models;

public class Supplier
{
    [Key]
    public Guid Id{ get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Field {0} needs to have more than {2} and less than {1} characters", MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(14, ErrorMessage = "Field {0} needs to have more than {2} and less than {1} characters", MinimumLength = 9)]
    public string Document { get; set; } = string.Empty;

    public int Type {  get; set; }

    public bool IsActive { get; set; }
}
