using StoreMarket003.Models;

namespace StoreMarket003.Contracts.Responses
{
    public class StoreResponse
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
