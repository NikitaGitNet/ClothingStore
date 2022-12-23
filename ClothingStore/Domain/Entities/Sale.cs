using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Domain.Entities
{
    public class Sale
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee? Employee { get; set; }
        public string? EmployeeName { get; set; }
        
        public float Price { get; set; }
        public DateTime DateOfSale = DateTime.Now;

        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
        public string? ProductName { get; set; }
    }
}
