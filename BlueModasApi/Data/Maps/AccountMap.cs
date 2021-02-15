
using BlueModasApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModasApi.Data.Maps {
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(1024).HasColumnType("varchar(50)");
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(1024).HasColumnType("varchar(50)");
            builder.Property(x => x.Document).IsRequired().HasMaxLength(1024).HasColumnType("varchar(15)");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(1024).HasColumnType("varchar(50)");
            builder.Property(x => x.Address).IsRequired().HasMaxLength(1024).HasColumnType("varchar(100)");
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(1024).HasColumnType("varchar(13)");
            builder.Property(x => x.Number).IsRequired().HasMaxLength(1024).HasColumnType("integer");
            builder.Property(x => x.ZipCode).IsRequired().HasMaxLength(1024).HasColumnType("varchar(10)");
            builder.Property(x => x.Neighborhood).IsRequired().HasMaxLength(1024).HasColumnType("varchar(50)");
            builder.Property(x => x.City).IsRequired().HasMaxLength(1024).HasColumnType("varchar(50)");
        }
    }
}