
using BlueModasApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModasApi.Data.Maps {
    public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("SaleItem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductId).IsRequired().HasMaxLength(1024).HasColumnType("integer");
            builder.Property(x => x.Price).IsRequired().HasMaxLength(1024).HasColumnType("decimal(18,5)");
            builder.Property(x => x.Quantity).IsRequired().HasMaxLength(1024).HasColumnType("integer");
            builder.HasOne(x => x.Sale).WithMany(x => x.SaleItem);
        }
    }
}