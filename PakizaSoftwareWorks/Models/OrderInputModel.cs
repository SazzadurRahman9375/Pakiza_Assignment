using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PakizaSoftwareWorks.Models
{
    public class OrderInputModel
    {
        public int OrderId { get; set; }
        public int OrderNo { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required, StringLength(50)]
        public string CustomerName { get; set; } = default!;
        [Required, StringLength(20)]
        public string Phone { get; set; } = default!;
        [Required, StringLength(50)]
        public string Address { get; set; } = default!;

        public virtual List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
