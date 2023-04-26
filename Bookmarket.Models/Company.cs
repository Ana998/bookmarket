using System.ComponentModel.DataAnnotations;

namespace Bookmarket.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Street address")]
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        [Display(Name = "Postal code")]
        public string? PostalCode { get; set; }
        [Display(Name = "Phone number")]
        public string? PhoneNumber { get; set; }
    }
}
