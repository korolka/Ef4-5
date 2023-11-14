using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL_V2.Entity.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> modelBuilder)
        {
            modelBuilder.Ignore(k => k.Id);
            modelBuilder.HasKey(k => new { k.ProductId, k.UserId });

            modelBuilder.HasOne(k => k.Product)
                .WithMany(k => k.Carts)
                .HasForeignKey(k => k.ProductId);

            modelBuilder.HasOne(k => k.User)
                .WithMany(k => k.Carts)
                .HasForeignKey(k => k.UserId);
        }
    }
}