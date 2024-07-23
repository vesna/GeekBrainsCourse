using StoreMarket001.Models;

namespace StoreMarket001.Contracts.Responses
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public CategoryResponse(Category category) { 
            Id = category.Id;
            Name = category.Name;
            Description = category.Description;
        }
    }
}
