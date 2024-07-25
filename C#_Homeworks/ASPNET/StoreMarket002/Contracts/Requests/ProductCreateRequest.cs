using StoreMarket002.Models;

namespace StoreMarket002.Contracts.Requests
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; } = decimal.Zero;
        public int? CategoryId { get; set; }
    }
}
