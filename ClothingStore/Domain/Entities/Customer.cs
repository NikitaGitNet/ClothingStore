using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        [Display(Name = "Имя")]
        public string? FirstName { get; set; }
        [Display(Name = "Фамилия")]
        public string? LastName { get; set; }
        [Display(Name = "Отчество")]
        public string? MiddleName { get; set; }
        [Display(Name = "Адрес электронной почты")]
        public string? Email { get; set; }
        [Display(Name = "Номер телефона в формате 7-917-000-00-00")]
        public int PhoneNumber { get; set; }
    }
}
