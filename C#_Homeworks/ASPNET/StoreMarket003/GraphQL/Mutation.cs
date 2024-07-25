using StoreMarket003.Abstractions;
using StoreMarket003.Contracts.Requests;
using StoreMarket003.Contracts.Responses;

namespace StoreMarket003.GraphQL
{
    public class Mutation
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IStoreService _storeService;

        public Mutation(IProductService productService, ICategoryService categoryService, IStoreService storeService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _storeService = storeService;
        }

        public int AddProduct(ProductCreateRequest request) => _productService.AddProduct(request);
        public bool DeleteProduct(int id) => _productService.DeleteProduct(id);
        public bool UpdateProductPrice(int id, decimal price) => _productService.UpdateProductPrice(id, price);

        public int AddCategory(CategoryCreateRequest request) => _categoryService.AddCategory(request);
        public bool DeleteCategory(int id) => _categoryService.DeleteCategory(id);
        public bool UpdateCategoryName(int id, string name) => _categoryService.UpdateCategoryName(id, name);

        public int AddStore(StoreCreateRequest store) => _storeService.AddStore(store);
        public bool DeleteStore(int id) => _storeService.DeleteStore(id);
        public bool AddProductToStore(ProductStoreCreateRequest request) => _storeService.AddProductToStore(request);
        public bool DeleteProductFromStore(int storeId, int productId) => _storeService.DeleteProductFromStore(storeId, productId);
        public bool UpdateStoreName(int id, string name) => _storeService.UpdateStoreName(id, name);
    }
}
