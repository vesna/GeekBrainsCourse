using System.ComponentModel.DataAnnotations;

namespace StoreMarket002.Models
{
    public class ProductModel
    {
        [Key]public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; } = decimal.Zero;
        public int? CategoryId { get; set;}
        public virtual CategoryModel? Category { get; set; }
        public virtual ICollection<StoreModel> Stores { get; set; } = new List<StoreModel>();
    }
}
