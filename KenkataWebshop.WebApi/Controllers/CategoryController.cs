using KenkataWebshop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace KenkataWebshop.WebApi.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        

        private readonly SqlContext _sqlContext;
        

        public CategoryController(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> GetAll()
        {
            List<CategoryDto> categories = new List<CategoryDto>();

            var _categories = await _sqlContext.Categories.ToListAsync();
            foreach (var category in _categories)
            {
                categories.Add(new CategoryDto() { Category = category.Name});
            }
            
            
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var category = await _sqlContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if(category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }
    }
}
