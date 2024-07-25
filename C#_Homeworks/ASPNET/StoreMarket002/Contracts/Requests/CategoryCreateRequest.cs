using StoreMarket002.Models;

namespace StoreMarket002.Contracts.Requests
{
    public class CategoryCreateRequest
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public CategoryModel GetEntity() { return new CategoryModel { Name = Name, Description = Description }; }
    }
}
