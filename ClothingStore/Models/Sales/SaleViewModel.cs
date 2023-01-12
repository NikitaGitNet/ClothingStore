using ClothingStore.Domain.Entities;

namespace ClothingStore.Models.Sales
{
    public class SaleViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfSale = DateTime.Now;
        public Guid EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public float Price { get; set; }
        public Guid ProductId { get; set; }
        public string? EmpolyeeName { get; set; }
        public string? ProductName { get; set; }
        public string? TitleImagePath { get; set; }
        public float Price { get; set; }
        public DateTime DateOfSale { get; set; }
    }
}
