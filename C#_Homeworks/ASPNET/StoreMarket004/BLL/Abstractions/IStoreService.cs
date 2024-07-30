using Contracts.Requests;
using Contracts.Responses;

namespace StoreMarket004.BLL.Abstractions
{
    public interface IStoreService
    {
        public int AddStore(StoreCreateRequest store);

        public IEnumerable<StoreResponse> GetStores();

        public StoreResponse? GetStoreById(int storeId);

        public bool DeleteStore(int id);

        public bool AddProductToStore(ProductStoreCreateRequest request);

        public bool DeleteProductFromStore(int storeId, int productId);

        public bool UpdateStoreName(int id, string name);

        // public CategoryResponse? GetCategoryByName(string name);
    }
}
