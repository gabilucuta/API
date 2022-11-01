using Internship2022WebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace Internship2022WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IStaticDatabase _staticDatabase;
        public ProductController(IStaticDatabase staticDatabase)
        {
            _staticDatabase = staticDatabase;
        }

        [HttpGet("getAllProducts")]
        public IActionResult Get()
        {
            return Ok(_staticDatabase.GetProducts());
        }

        [HttpGet("get/{keyword}")]
        public IActionResult GetById(Guid id)
        {
            Product product = _staticDatabase.GetById(id);
            if (product is null)
                return NotFound();

            return Ok(product);
        }
        

        [HttpPost("create")]
        public IActionResult Edit(Product product)
        {
            return Ok(_staticDatabase.AddProduct(product));
        }

        [HttpDelete("delete")]
        public IActionResult RemoveProdcutByID(Guid id)
        {
            Product product = _staticDatabase.GetById(id);
            if (product is null)
                return NotFound();

            

            return Ok(_staticDatabase.RemoveProdcut(product));
        }
    }
}
