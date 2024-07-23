using Microsoft.AspNetCore.Mvc;
using StoreMarket001.Contexts;
using StoreMarket001.Contracts.Requests;
using StoreMarket001.Contracts.Responses;
using StoreMarket001.Models;

namespace StoreMarket001.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoresController : ControllerBase
    {
        private StoreContext _context;
        public CategoresController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("categories/{id}")]
        public ActionResult<CategoryResponse> GetCategory(int id)
        {
            var result = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(new CategoryResponse(result));
            }
        }

        [HttpGet]
        [Route("categories")]
        public ActionResult<IEnumerable<CategoryResponse>> GetCategories()
        {
            var result = _context.Categories;

            return Ok(result.Select(result => new CategoryResponse(result)));
        }

        [HttpPost]
        [Route("categories")]
        public ActionResult<CategoryResponse> AddCategory(CategoryCreateRequest request)
        {
            var category = request.GetEntity();
            try
            {
                var result = _context.Categories.Add(category).Entity;
                _context.SaveChanges();
                return Ok(new CategoryResponse(result));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteCategory(CategoryDeleteRequest request)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == request.Id);
            var products = _context.Products.Where(c => c.CategoryId == request.Id);

            if (category != null && products == null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        [HttpPut]
        [Route("Categories/{id}")]
        public ActionResult<CategoryResponse> UpdateCategory(CategoryUpdateRequest request)
        {
            Category category = request.GetEntity();
            try
            {
                var result = _context.Categories.Update(category).Entity;
                _context.SaveChanges();
                return Ok(new CategoryResponse(result));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
