using ClothingStore.Domain.Entities;

namespace ClothingStore.Models.Sales
{
    public class SaleViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfSale { get; set; }
        public Guid EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
