using StoreMarket003.Abstractions;
using StoreMarket003.Contracts.Responses;

namespace StoreMarket003.GraphQL
{
    public class Query
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IStoreService _storeService;

        public Query(IProductService productService, ICategoryService categoryService, IStoreService storeService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _storeService = storeService;
        }

        public ProductResponse? GetProduct(int id) => _productService.GetProductById(id);

        public IEnumerable<ProductResponse> GetProducts() => _productService.GetProducts();

        public CategoryResponse? GetCategory(int id) => _categoryService.GetCategoryById(id);

        public IEnumerable<CategoryResponse> GetCategories() => _categoryService.GetCategories();

        public IEnumerable<StoreResponse> GetStores() => _storeService.GetStores();

        public StoreResponse? GetStoreById(int storeId) => _storeService.GetStoreById(storeId);
    }
}
