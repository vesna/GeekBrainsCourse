using System.ComponentModel.DataAnnotations;

namespace StoreMarket002.Models
{
    public class CategoryModel
    {
        [Key]public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<ProductModel> Products { get; set; } = new List<ProductModel>();
    }
}
