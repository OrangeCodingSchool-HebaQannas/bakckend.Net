using Microsoft.Identity.Client;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Identity2.Models

{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Range(1,50000)]
        [Column(TypeName = "decimal(18,2)")]

        public decimal Price { get; set; }

        // fields for bags/watches
        public string? Brand { get; set; }
        public string? ImageUrl { get; set; }
        public int StockQuantity { get; set; }

        // Relationship to Category
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public int BrandId { get; set; }

        [ForeignKey("BrandId")]
        public Brand? BrandNavigation { get; set; }

    }
}
