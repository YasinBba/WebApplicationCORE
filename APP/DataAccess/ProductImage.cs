using CORE.Entities;

namespace APP.DataAccess
{
    public class ProductImage : Entity
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }
    }

}
