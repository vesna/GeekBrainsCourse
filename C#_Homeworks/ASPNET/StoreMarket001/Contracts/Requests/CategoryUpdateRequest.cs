using StoreMarket001.Models;

namespace StoreMarket001.Contracts.Requests
{
    public class CategoryUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public Category GetEntity() { return new Category { Id = Id, Name = Name, Description = Description }; }
    }
}
