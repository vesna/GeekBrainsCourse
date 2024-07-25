using Microsoft.AspNetCore.Mvc;
using StoreMarket002.Abstractions;
using StoreMarket002.Contexts;
using StoreMarket002.Contracts.Requests;
using StoreMarket002.Contracts.Responses;
using StoreMarket002.Models;

namespace StoreMarket002.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoresController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoresController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("categories/{id}")]
        public ActionResult<CategoryResponse> GetCategory(int id)
        {
            return Ok(_service.GetCategoryById(id));
        }

        [HttpGet]
        [Route("categories")]
        public ActionResult<IEnumerable<CategoryResponse>> GetCategories()
        {
            return Ok(_service.GetCategorys());
        }

        [HttpPost]
        [Route("create")]
        public ActionResult<CategoryResponse> AddCategory(CategoryCreateRequest request)
        {
            try
            {
                if (_service.GetCategoryByName(request.Name) != null)
                {
                    return BadRequest(409);
                }
                return Ok(_service.AddCategory(request));
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
            _service.DeleteCategory(request);
        }

        [HttpPut]
        [Route("update/{id}")]
        public ActionResult<CategoryResponse> UpdateCategory(CategoryUpdateRequest request)
        {
            try
            {
                return Ok(_service.UpdateCategory(request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
