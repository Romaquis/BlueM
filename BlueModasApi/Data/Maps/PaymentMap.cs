using BlueModasApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModasApi.Data.Maps {
    public class PaymentMap : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payment");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NameCard).IsRequired().HasMaxLength(120).HasColumnType("varchar(100)");
            builder.Property(x => x.NumberCard).IsRequired().HasMaxLength(1024).HasColumnType("varchar(20)");
            builder.Property(x => x.ExpirationDate).IsRequired().HasMaxLength(1024).HasColumnType("varchar(7)");
            builder.Property(x => x.SecurityCode).IsRequired().HasMaxLength(1024).HasColumnType("integer");
            //builder.HasOne(x => x.Account).WithOne(y => y.Payment).HasForeignKey<Account>(a => a.Payment);
        }
    }
}