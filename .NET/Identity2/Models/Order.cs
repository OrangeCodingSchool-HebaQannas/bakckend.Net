using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Identity2.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        //link order to user
        [Required]
        public string UserId { get; set; }
        public virtual IdentityUser User { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
