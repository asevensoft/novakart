using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NovaKart.Domain.Entities;

namespace NovaKart.Infraestructure.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasOne(image => image.Product)
                .WithOne(product => product.Image)
                .HasForeignKey<ProductImage>(image => image.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
