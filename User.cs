using System.ComponentModel.DataAnnotations;

namespace Felhasznalok
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        public string Email { get; set; }
    }
}
