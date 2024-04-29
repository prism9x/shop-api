using Microsoft.AspNetCore.Mvc;
using Prism.Application.Service;

namespace Prism.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _categoryService.GetCategories());
        }
    }
}