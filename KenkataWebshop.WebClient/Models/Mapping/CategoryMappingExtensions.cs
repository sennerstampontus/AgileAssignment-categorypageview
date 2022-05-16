using KenkataWebshop.Data;

namespace KenkataWebshop.WebClient.Models.Mapping
{
    public static class CategoryMappingExtensions
    {
        public static CategoryViewModel MapToViewModel(this CategoryDto dto)
        {
            var viewModel = new CategoryViewModel
            {
                Category = dto.Category,
                Products = dto.Products
            };

            return viewModel;
        }

        public static List<CategoryViewModel> MapToViewModel(this List<ProductDto> dtos)
        {
            var viewModels = new List<CategoryViewModel>();

            foreach (var dto in dtos)
            {
                viewModels.Add(dto.MapToViewModel());
            }

            return viewModels;
        }
    }
}
