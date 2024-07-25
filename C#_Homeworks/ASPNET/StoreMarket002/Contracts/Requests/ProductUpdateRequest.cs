using StoreMarket002.Models;

namespace StoreMarket002.Contracts.Requests
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; } = decimal.Zero;
        public int? CategoryId { get; set; }

        public ProductModel GetEntity()
        {
            return new ProductModel { Id = Id, Name = Name, Description = Description, Price = Price, CategoryId = CategoryId };
        }
    }
}
