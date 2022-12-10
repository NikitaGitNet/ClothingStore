using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid SizeId { get; set; }
        [ForeignKey("SizeId")]
        public Guid BrandId { get; set; }
        [ForeignKey("BrandId")]
        public int Count { get; set; }
        public float Price { get; set; }
    }
}
