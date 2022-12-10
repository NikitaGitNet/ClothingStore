using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Domain.Entities
{
    public class Sale
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public float Price { get; set; }
        public DateTime DateOfSale { get; set; }
    }
}
