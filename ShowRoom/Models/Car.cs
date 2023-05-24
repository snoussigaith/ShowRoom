using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShowRoom.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Poster")]
        public string? ImageUrl { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public Type Type { get; set; }
        [Required]
        public string Option { get; set; }
        [Required]
        public decimal Prix { get; set; }
        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; } = null!;
    }
}
