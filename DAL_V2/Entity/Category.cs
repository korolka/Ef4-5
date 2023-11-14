using System.ComponentModel.DataAnnotations;

namespace DAL_V2.Entity
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Icon { get; set; }

        public List<Product> Products { get; set; }
    }
}