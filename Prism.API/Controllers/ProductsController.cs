using Microsoft.AspNetCore.Mvc;
using Prism.Application.Abstract;

namespace Prism.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _productService.GetProducts());
        }
    }
}