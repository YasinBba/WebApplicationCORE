using CORE.Models;
using System.ComponentModel.DataAnnotations;

namespace APP.Business.Models
{
    public class CategoryResponse: Response
    {
        [Required, StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
