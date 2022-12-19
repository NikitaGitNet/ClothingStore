using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Domain.Entities
{
    public class Sale
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public string? EmployeeName { get; set; }
        public Employee? Employee { get; set; }
        public float Price { get; set; }
        public DateTime DateOfSale { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
