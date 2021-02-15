
using BlueModasApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModasApi.Data.Maps {
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(120).HasColumnType("varchar(50)");
            builder.Property(x => x.Description).IsRequired().HasMaxLength(1024).HasColumnType("varchar(100)");
            builder.Property(x => x.Image).IsRequired().HasMaxLength(1024).HasColumnType("varchar(250)");
            builder.Property(x => x.Price).IsRequired().HasColumnType("money");
        }
    }
}