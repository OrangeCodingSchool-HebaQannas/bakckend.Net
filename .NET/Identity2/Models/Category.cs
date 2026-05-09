using System.ComponentModel.DataAnnotations;

namespace Identity2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage ="Please enter a category name")]

        [StringLength(50, MinimumLength =3, ErrorMessage ="Category name must be between 3 and 50 characters")]

        [Display(Name ="Category Name")]
        public string Name { get; set; }

        // One Category can have many products
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
