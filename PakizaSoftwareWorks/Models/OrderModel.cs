namespace PakizaSoftwareWorks.Models
{
    public class OrderModel
    {

        public Customer Customer { get; set; } = default!;
        public OrderItemModel OrderItem { get; set; } = default!;
    }
}
