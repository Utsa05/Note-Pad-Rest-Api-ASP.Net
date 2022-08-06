using Microsoft.AspNetCore.Mvc;
using Product.Dtos;
using Product.Repositories;

namespace Product.Controllers.Controllers
{

    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository? productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IEnumerable<ProductDto> GetProducts()
        {
            var products = productRepository!.GetProducts().Select(item => item.AsDto());
            return products;

        }

        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetProduct(Guid id)
        {
            var product = productRepository!.GetProduct(id);
            if (product is null)
            {
                return NotFound();
            }

            return product.AsDto();
        }
    }
}