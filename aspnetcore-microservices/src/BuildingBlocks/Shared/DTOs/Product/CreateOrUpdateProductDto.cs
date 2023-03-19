using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs.Product;

public abstract class CreateOrUpdateProductDto
{
    [Required]
    [MaxLength(250, ErrorMessage = "Maximum length for Product Name is 250 character.")]
    public string Name { get; set; }
    
    [MaxLength(255, ErrorMessage = "Maximum length for Product Name is 255 character.")]
    public string Summary { get; set; }
    
    public string Description { get; set; }
    
    public decimal Price { get; set; }
}