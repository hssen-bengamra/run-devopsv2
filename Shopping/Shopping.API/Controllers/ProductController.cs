using Microsoft.AspNetCore.Mvc;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController: ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return  Enumerable.Range(1, 5).Select(x => new Product
            {
                Id= x.ToString(),
                Name = "asd",
                Category = "category 1",
                Description = x.ToString(),
                Price=x * 100
                
            }).ToArray();
        }
    }
}
