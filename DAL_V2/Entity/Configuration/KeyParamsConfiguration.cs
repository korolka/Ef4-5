using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL_V2.Entity.Configuration
{
    public class KeyParamsConfgiuration : IEntityTypeConfiguration<KeyParams>
    {
        public void Configure(EntityTypeBuilder<KeyParams> modelBuilder)
        {
            modelBuilder.Ignore(k => k.Id);
            modelBuilder.HasKey(k => new { k.ProductId, k.KeyWordId });

            modelBuilder.HasOne(k => k.Product)
                .WithMany(k => k.KeyParams)
                .HasForeignKey(k => k.ProductId);

            modelBuilder.HasOne(k => k.KeyWord)
                .WithMany(k => k.ProductLinks)
                .HasForeignKey(k => k.KeyWordId);
        }
    }
}