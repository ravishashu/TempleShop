using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheShop.Models;

namespace TheShop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public SearchController(IProductRepository pieRepository)
        {
            _productRepository = pieRepository;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var allProducts = _productRepository.AllProducts;
            return Ok(allProducts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (!_productRepository.AllProducts.Any(p => p.ProductId == id))
                return NotFound();
            //return new JsonResult(_productRepository.AllProducts.Where(p =>p.ProductId == id);
            return Ok(_productRepository.AllProducts.Where(p => p.ProductId == id));
        }

        [HttpPost]
        public IActionResult SearchProducts([FromBody] string searchQuery)
        {
            IEnumerable<Product> pies = new List<Product>();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                pies = _productRepository.SearchProducts(searchQuery);
            }
            return new JsonResult(pies);
        }
    }
}
