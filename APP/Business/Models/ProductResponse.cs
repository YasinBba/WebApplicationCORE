using CORE.Models;
using System.ComponentModel;

namespace APP.Business.Models
{
    public class ProductResponse : Response
    {
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int? StockAmount { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool IsContinued { get; set; }
        public int CategoryId { get; set; }
        
        // Navigation property
        public CategoryResponse Category { get; set; }
    }
}
