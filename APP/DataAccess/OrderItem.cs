using CORE.Entities;

namespace APP.DataAccess
{
    public class OrderItem : Entity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

}
