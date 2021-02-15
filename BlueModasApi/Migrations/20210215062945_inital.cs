using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueModasApi.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 1024, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 1024, nullable: false),
                    Document = table.Column<string>(type: "varchar(15)", maxLength: 1024, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 1024, nullable: false),
                    Phone = table.Column<string>(type: "varchar(13)", maxLength: 1024, nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", maxLength: 1024, nullable: false),
                    Number = table.Column<int>(type: "integer", maxLength: 1024, nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(10)", maxLength: 1024, nullable: false),
                    Neighborhood = table.Column<string>(type: "varchar(50)", maxLength: 1024, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameCard = table.Column<string>(type: "varchar(100)", maxLength: 120, nullable: false),
                    NumberCard = table.Column<string>(type: "varchar(20)", maxLength: 1024, nullable: false),
                    ExpirationDate = table.Column<string>(type: "varchar(7)", maxLength: 1024, nullable: false),
                    SecurityCode = table.Column<int>(type: "integer", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(50)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 1024, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Image = table.Column<string>(type: "varchar(250)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sale_Account_Id",
                        column: x => x.Id,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sale_Payment_Id",
                        column: x => x.Id,
                        principalTable: "Payment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    SaleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleItem_Sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleItem_SaleId",
                table: "SaleItem",
                column: "SaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SaleItem");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
