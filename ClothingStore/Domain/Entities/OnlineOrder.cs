using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Domain.Entities
{
    public class OnlineOrder
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public string? Details { get; set; }
        public DateTime DataOrder { get; set; }
        public float Price { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
