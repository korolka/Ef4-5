namespace DAL_V2.Entity
{
    public class Cart : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}