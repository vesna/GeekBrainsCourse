using System.ComponentModel.DataAnnotations;

namespace StoreMarket001.Models
{
    public class Store
    {
        [Key]public int Id { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
