using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreMarket002.Abstractions;
using StoreMarket002.Contexts;
using StoreMarket002.Contracts.Requests;
using StoreMarket002.Contracts.Responses;
using StoreMarket002.Models;
using System.Text;

namespace StoreMarket002.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductsController(IProductService service) { 
            _service = service;
        }

        [HttpGet]
        [Route("products/{id}")]
        public ActionResult<ProductResponse> GetProduct(int id)
        {
            return Ok(_service.GetProductById(id));
        }

        [HttpGet]
        [Route("products")]
        public ActionResult<IEnumerable<ProductResponse>> GetProducts()
        {
            return Ok(_service.GetProducts());
        }

        [HttpPost]
        [Route("create")]
        public ActionResult<int> AddProduct(ProductCreateRequest request)
        {            
            try
            {
                if (_service.GetProductByName(request.Name) != null)
                {
                    return BadRequest(409);
                }
                return Ok(_service.AddProduct(request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getBooksCSV")]
        public FileContentResult GetProductsCsv()
        {
            var content = GetCsv(_service.GetProducts());
               
            return File(new UTF8Encoding().GetBytes(content), "text/csv", "products.csv");
        }

        private string GetCsv(IEnumerable<ProductResponse> products)
        {
            var csv = new StringBuilder();
            foreach (var product in products)
            {
                csv.AppendLine(product.Name +";" + product.Description + ";" + product.Price);
            }
            return csv.ToString();
        }

        [HttpGet]
        [Route("getBooksCSVUrl")]
        public ActionResult<string> GetProductsCsvUrl()
        {
            var content = GetCsv(_service.GetProducts());

            string fileName = null;// File(new UTF8Encoding().GetBytes(content), "text/csv", "products.csv");
            fileName = "products" + DateTime.Now.ToBinary().ToString() + ".csv";
            System.IO.File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "StaticFiles", fileName), content);

            return "https://" + Request.Host.ToString() + "/static/" + fileName;
        }



        [HttpDelete]
        [Route("{id}")]
        public void DeleteProduct(ProductDeleteRequest request)
        {
            _service.DeleteProduct(request);            
        }

        [HttpPut]
        [Route("update/{id}")]
        public ActionResult<ProductResponse> UpdateProduct(ProductUpdateRequest request)
        {
            try
            {
                return Ok(_service.UpdateProduct(request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
