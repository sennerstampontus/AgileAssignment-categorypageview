using KenkataWebshop.Data;
using Microsoft.AspNetCore.Mvc;

namespace KenkataWebshop.WebClient.Controllers
{
    public class CategoryViewModel
    {
        public string Category { get; set; }
        public List<ProductDto> Products { get; set; }
    }
  
    public class CategoryController : Controller
    {

        [Route("Category")]
        public IActionResult Index()
        {


            var categoryViewModels = new List<CategoryViewModel>
            {
                new CategoryViewModel{Category = "Men"},
                new CategoryViewModel{Category = "Women"},
                new CategoryViewModel{Category = "Kids"},
                new CategoryViewModel{Category = "Shoes"},
                new CategoryViewModel{Category = "Hats"},
                new CategoryViewModel{Category = "Watches"}
            };

            return View(categoryViewModels);
        }
    }
}

