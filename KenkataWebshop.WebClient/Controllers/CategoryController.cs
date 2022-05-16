using KenkataWebshop.Data;
using Microsoft.AspNetCore.Mvc;

namespace KenkataWebshop.WebClient.Controllers
{
 
    public class CategoryController : Controller
    {
        private readonly HttpClient _httpClient;

        public CategoryController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [Route("Category")]
        public IActionResult Index()
        {
            //var categoryViewModels = new List<CategoryViewModel>
            //{
            //    new CategoryViewModel{Category = "Men"},
            //    new CategoryViewModel{Category = "Women"},
            //    new CategoryViewModel{Category = "Kids"},
            //    new CategoryViewModel{Category = "Shoes"},
            //    new CategoryViewModel{Category = "Hats"},
            //    new CategoryViewModel{Category = "Watches"}
            //};

            return View();
        }
    }
}

