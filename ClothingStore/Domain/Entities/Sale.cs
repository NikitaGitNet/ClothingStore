using ClothingStore.TestData.Employees;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Domain.Entities
{
    public class Sale
    {
        public Guid Id { get; set; }
        public string? EmployeeId = GenaBukin.Id;
        [ForeignKey("EmployeeId")]
        public string EmployeeName = GenaBukin.FirstName + " " + GenaBukin.LastName;
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public string? ProductName { get; set; }
        public string? TitleImagePath { get; set; }
        public float Price { get; set; }
        public DateTime DateOfSale = DateTime.Now;
    }
}
