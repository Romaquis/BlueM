using BlueModasApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModasApi.Data.Maps {
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Account).WithOne(x => x.Sale).HasForeignKey<Sale>(x => x.Id);
            builder.HasOne(x => x.Payment).WithOne(x => x.Sale).HasForeignKey<Sale>(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired();
        }
    }
}