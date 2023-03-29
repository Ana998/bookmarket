using System.ComponentModel.DataAnnotations;

namespace Bookmarket.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cover type")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
