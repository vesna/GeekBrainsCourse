using Microsoft.AspNetCore.Mvc;
using StoreMarket002.Contracts.Requests;
using StoreMarket002.Contracts.Responses;
using StoreMarket002.Models;

namespace StoreMarket002.Abstractions
{
    public interface IProductService
    {
        public int AddProduct(ProductCreateRequest product);

        public IEnumerable<ProductResponse> GetProducts();

        public ProductResponse? GetProductById(int productId);

        public void DeleteProduct(ProductDeleteRequest request);

        public ProductResponse UpdateProduct(ProductUpdateRequest request);

        public ProductResponse? GetProductByName(string name);
    }
}
