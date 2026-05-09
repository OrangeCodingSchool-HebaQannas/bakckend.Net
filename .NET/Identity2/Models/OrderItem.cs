using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Identity2.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        [Range(1,10,ErrorMessage ="You can only buy between 1 and 10 of a single item")]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PriceAtPurchase { get; set; }//if sale
    }
}
