using System.ComponentModel.DataAnnotations;

namespace DAL_V2.Entity
{
    public class Product : BaseEntity
    {
        [Required]
        public string Name { get; set; } = null!;

        [MinLength(0)]
        public double Price { get; set; }

        [MinLength(0)]
        public double ActionPrice { get; set; }
        public string Description { get; set; }
        public string DescriptionField1 { get; set; }
        public string DescriptionField2 { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<KeyParams> KeyParams { get; set; } = new List<KeyParams>();
    }
}