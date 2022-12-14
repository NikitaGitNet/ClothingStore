using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Domain.Entities
{
    public class Size
    {
        public Guid Id { get; set; }
        [Display(Name = "Размер")]
        public string? Name { get; set; }
        [Display(Name = "Обхват груди")]
        public string? ChestCircumference { get; set; }
        [Display(Name = "Обхват талии")]
        public string? WaistCircumference { get; set; }
        [Display(Name = "Обхват бедер")]
        public string? HipCircumference { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
