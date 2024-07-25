using StoreMarket003.Contracts.Requests;
using StoreMarket003.Contracts.Responses;

namespace StoreMarket003.Abstractions
{
    public interface ICategoryService
    {
        public int AddCategory(CategoryCreateRequest category);

        public IEnumerable<CategoryResponse> GetCategories();

        public CategoryResponse? GetCategoryById(int categoryId);

        public bool DeleteCategory(int id);

        public bool UpdateCategoryName(int id, string name);

        // public CategoryResponse? GetCategoryByName(string name);
    }
}