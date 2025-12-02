using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
        [NotMapped]
        public double TotalAmount { get; set; }
    }
}
