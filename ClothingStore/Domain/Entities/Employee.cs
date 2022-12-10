namespace ClothingStore.Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Post { get; set; }
        public float Tariff { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public int Bonus { get; set; }
    }
}
