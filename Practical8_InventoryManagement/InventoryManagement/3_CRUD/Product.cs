using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class Product
{
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Product name is required")]
    [StringLength(100, ErrorMessage = "Product name can be 100 characters at most")]
    [Display(Name = "Product Name")]
    public string ProductName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Category is required")]
    [StringLength(50, ErrorMessage = "Category can be 50 characters at most")]
    public string Category { get; set; } = string.Empty;

    [Range(0.01, 999999999, ErrorMessage = "Price must be greater than 0")]
    public decimal Price { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "Supplier is required")]
    [StringLength(100, ErrorMessage = "Supplier can be 100 characters at most")]
    public string Supplier { get; set; } = string.Empty;
}
