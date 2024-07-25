using StoreMarket002.Models;

namespace StoreMarket002.Contracts.Responses
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public CategoryResponse(CategoryModel category) { 
            Id = category.Id;
            Name = category.Name;
            Description = category.Description;
        }
    }
}
