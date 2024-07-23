using StoreMarket001.Models;

namespace StoreMarket001.Contracts.Requests
{
    public class CategoryCreateRequest
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public Category GetEntity() { return new Category { Name = Name, Description = Description }; }
    }
}
