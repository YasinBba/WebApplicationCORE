using CORE.Models;
using System.ComponentModel.DataAnnotations;
namespace APP.Business.Models
{
    public class ProductRequest : Request
    {
        [Required, StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required, Range(0.01, 100000.00)]
        public decimal UnitPrice { get; set; }
        public int? StockAmount { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool IsContinued { get; set; }
        public int CategoryId { get; set; }
    }
    
    
}
