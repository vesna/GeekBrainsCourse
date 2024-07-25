using StoreMarket002.Models;

namespace StoreMarket002.Contracts.Requests
{
    public class CategoryUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public CategoryModel GetEntity() { return new CategoryModel { Id = Id, Name = Name, Description = Description }; }
    }
}
