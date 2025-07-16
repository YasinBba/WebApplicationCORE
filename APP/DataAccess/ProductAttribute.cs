using CORE.Entities;

namespace APP.DataAccess
{
    public class ProductAttribute : Entity
    {
        public int ProductId { get; set; }
        public string AttributeName { get; set; } // "Color", "Size"
        public string AttributeValue { get; set; } // "Red", "XL"
    }

}
