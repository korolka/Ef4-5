using System.ComponentModel.DataAnnotations;

namespace DAL_V2.Entity
{
    public class User : BaseEntity
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Login { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        public List<Cart> Carts { get; set; }
    }
}