using KenkataWebshop.WebClient.Models;

namespace KenkataWebshop.WebClient.Models.Fixtures
{
    public class CategoryFixtures
    {

        public List<CategoryViewModel> GetAll()
        {
            var _categoryViewModels = new List<CategoryViewModel>
            {
                new CategoryViewModel{Category = "Men"},
                new CategoryViewModel{Category = "Women"},
                new CategoryViewModel{Category = "Kids"},
                new CategoryViewModel{Category = "Shoes"},
                new CategoryViewModel{Category = "Hats"},
                new CategoryViewModel{Category = "Watches"}
            };

            return _categoryViewModels;
        }
    }
}
