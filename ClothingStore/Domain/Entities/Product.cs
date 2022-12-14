using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public string? TitleImagePath { get; set; }

        public Guid SizeId { get; set; }
        [ForeignKey("SizeId")]
        public Size? Size { get; set; }
        public string? SizeName { get; set; }

        public Guid BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }
        public string? BrandName { get; set; }
        
        public Guid ClothingTypeId { get; set; }
        [ForeignKey("ClothingTypeId")]
        public string? ClothingTypeName { get; set; }
        public ClothingType? ClothingType { get; set; }
    }
}
