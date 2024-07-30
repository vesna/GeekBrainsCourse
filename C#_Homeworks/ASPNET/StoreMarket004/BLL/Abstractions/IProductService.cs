using Contracts.Requests;
using Contracts.Responses;

namespace StoreMarket004.BLL.Abstractions
{
    public interface IProductService
    {
        public int AddProduct(ProductCreateRequest product);

        public IEnumerable<ProductResponse> GetProducts();

        public ProductResponse? GetProductById(int productId);

        public bool DeleteProduct(int id);

        public bool UpdateProductPrice(int id, decimal price);

        // public ProductResponse? GetProductByName(string name);
    }
}
