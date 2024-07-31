using Contracts.Requests;
using StoreMarket004.BLL.Abstractions;

namespace StoreMarket004.GraphQL
{
    public class Mutation
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IStoreService _storeService;
        private readonly IAuthService _authService;

        public Mutation(IProductService productService, ICategoryService categoryService, IStoreService storeService, IAuthService authService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _storeService = storeService;
            _authService = authService;
        }

        public int AddProduct(ProductCreateRequest request, string t) => _productService.AddProduct(request, t);
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

        public string? Register(UserAuthRequest request) => _authService.Register(request);
    }
}
