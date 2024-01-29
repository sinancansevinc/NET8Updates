using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET8Updates.API.Models;
using NET8Updates.API.Services;

namespace NET8Updates.API.Controllers
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
        public IActionResult GetProducts()
        {
            List<Product> products = [];

            products.AddRange(_productService.GetProducts());

            return Ok(products);


        }
    }
}
