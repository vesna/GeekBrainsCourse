using Microsoft.AspNetCore.Mvc;
using StoreMarket001.Contexts;
using StoreMarket001.Contracts.Requests;
using StoreMarket001.Contracts.Responses;
using StoreMarket001.Models;

namespace StoreMarket001.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private StoreContext _context;
        public ProductsController(StoreContext context) { 
            _context = context;
        }

        [HttpGet]
        [Route("products/{id}")]
        public ActionResult<ProductResponse> GetProduct(int id)
        {
            var result = _context.Products.FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(new ProductResponse(result));
            }
        }

        [HttpGet]
        [Route("products")]
        public ActionResult<IEnumerable<ProductResponse>> GetProducts()
        {
            var result = _context.Products;
            
            return Ok(result.Select(result => new ProductResponse(result)));
        }

        [HttpPost]
        [Route("products")]
        public ActionResult<ProductResponse> AddProduct(ProductCreateRequest request)
        {
            Product product = request.GetEntity();
            try
            {
                var result = _context.Products.Add(product).Entity;
                _context.SaveChanges();
                return Ok(new ProductResponse(result));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteProduct(ProductDeleteRequest request)
        {
            var result = _context.Products.FirstOrDefault(x => x.Id == request.Id);

            if (result != null)
            {
                _context.Products.Remove(result);
                _context.SaveChanges();
            }
            
        }

        [HttpPut]
        [Route("products/{id}")]
        public ActionResult<ProductResponse> UpdateProduct(ProductUpdateRequest request)
        {
            Product product = request.GetEntity();
            try
            {
                var result = _context.Products.Update(product).Entity;
                _context.SaveChanges();
                return Ok(new ProductResponse(result));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
