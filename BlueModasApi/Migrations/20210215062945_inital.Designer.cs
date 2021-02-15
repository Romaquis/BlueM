﻿// <auto-generated />
using System;
using BlueModasApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlueModasApi.Migrations
{
    [DbContext(typeof(StoreDataContext))]
    [Migration("20210215062945_inital")]
    partial class inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlueModasApi.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(1024);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(1024);

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(1024);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(1024);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(1024);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(1024);

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(1024);

                    b.Property<int>("Number")
                        .HasColumnType("integer")
                        .HasMaxLength(1024);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(13)")
                        .HasMaxLength(1024);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("BlueModasApi.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExpirationDate")
                        .IsRequired()
                        .HasColumnType("varchar(7)")
                        .HasMaxLength(1024);

                    b.Property<string>("NameCard")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(120);

                    b.Property<string>("NumberCard")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(1024);

                    b.Property<int>("SecurityCode")
                        .HasColumnType("integer")
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("BlueModasApi.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(1024);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(1024);

                    b.Property<decimal>("Price")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(120);

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("BlueModasApi.Models.Sale", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("CreateDate");

                    b.HasKey("Id");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("BlueModasApi.Models.SaleItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int?>("SaleId");

                    b.HasKey("Id");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleItem");
                });

            modelBuilder.Entity("BlueModasApi.Models.Sale", b =>
                {
                    b.HasOne("BlueModasApi.Models.Account", "Account")
                        .WithOne("Sale")
                        .HasForeignKey("BlueModasApi.Models.Sale", "Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlueModasApi.Models.Payment", "Payment")
                        .WithOne("Sale")
                        .HasForeignKey("BlueModasApi.Models.Sale", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BlueModasApi.Models.SaleItem", b =>
                {
                    b.HasOne("BlueModasApi.Models.Sale", "Sale")
                        .WithMany("SaleItem")
                        .HasForeignKey("SaleId");
                });
#pragma warning restore 612, 618
        }
    }
}
