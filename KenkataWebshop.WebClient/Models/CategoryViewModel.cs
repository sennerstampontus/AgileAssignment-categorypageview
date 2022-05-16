using KenkataWebshop.Data;

namespace KenkataWebshop.WebClient.Models
{
    public class CategoryViewModel
    {
        public string Category { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
