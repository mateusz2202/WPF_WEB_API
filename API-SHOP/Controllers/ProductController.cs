using API_SHOP.IServices;
using API_SHOP.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_SHOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public ActionResult Create([FromBody] ProductDTO dto)
        {
            _productService.CreateProduct(dto);
            return Ok();
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetAll()
        {
            var result = _productService.GetAll();
            return Ok(result);
        }
        [HttpGet("{id}")]    
        public ActionResult<ProductDTO> GetById([FromRoute] int id)
        {
            var result = _productService.GetById(id);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            _productService.DeleteProduct(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public ActionResult Update([FromBody] ProductDTO dto, [FromRoute] int id)
        {
            _productService.UpdateProduct(id, dto);
            return Ok();
        }
    }
}
