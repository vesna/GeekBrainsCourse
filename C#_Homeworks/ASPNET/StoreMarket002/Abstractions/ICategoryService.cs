using StoreMarket002.Contracts.Requests;
using StoreMarket002.Contracts.Responses;

namespace StoreMarket002.Abstractions
{
    public interface ICategoryService
    {
        public int AddCategory(CategoryCreateRequest category);

        public IEnumerable<CategoryResponse> GetCategorys();

        public CategoryResponse? GetCategoryById(int categoryId);

        public void DeleteCategory(CategoryDeleteRequest request);

        public CategoryResponse UpdateCategory(CategoryUpdateRequest request);

        public CategoryResponse? GetCategoryByName(string name);
    }
}
