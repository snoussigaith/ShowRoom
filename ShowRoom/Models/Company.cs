using System.ComponentModel.DataAnnotations;

namespace ShowRoom.Models
{
    public class Company
    {
        public Company()
        {
            Cars = new HashSet<Car>();

        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Nat { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
