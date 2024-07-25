using System.ComponentModel.DataAnnotations;

namespace StoreMarket002.Models
{
    public class StoreModel
    {
        [Key]public int Id { get; set; }
        public int Count { get; set; }
        public virtual ICollection<ProductModel> Products { get; set; } = new List<ProductModel>();
    }
}
