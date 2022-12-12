using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Domain.Entities
{
    public class Brand
    {
        public Guid Id { get; set; }
        [Display(Name = "Производитель")]
        public string? Name { get; set; }
        [Display(Name = "Страна производитель")]
        public string? ManufacturerCountry { get; set; }
        public string? TitleImagePath { get; set; }
    }
}
