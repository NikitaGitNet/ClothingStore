namespace ClothingStore.Model.Products
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Count { get; set; }
        public string? TitleImagePath { get; set; }
        public string? Brand { get; set; }
        public string? ClothingType { get; set; }
    }
}
