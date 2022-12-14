namespace ClothingStore.Domain.Entities
{
    public class ClothingType
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
