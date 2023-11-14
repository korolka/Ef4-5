using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_V2.Entity
{
    public class KeyParams : BaseEntity
    {
        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public Guid KeyWordId { get; set; }

        [ForeignKey(nameof(KeyWordId))]
        public Word KeyWord { get; set; }
    }
}