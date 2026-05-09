using System.ComponentModel.DataAnnotations;

namespace Identity2.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Brand Name")]
        public string Name { get; set; }

        public string? Description { get; set; }

        // One Brand can have many products
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
