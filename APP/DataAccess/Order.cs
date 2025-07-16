using CORE.Entities;

namespace APP.DataAccess
{
    public class Order : Entity
    {
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public string Status { get; set; }
    }

}
