using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDelivery.Api.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    OfferType = table.Column<int>(type: "int", nullable: false),
                    OfferedValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ValidTill = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BgColor = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "burgers.png", "Burgers" },
                    { 2, "desserts.png", "Desserts" },
                    { 3, "drinks.png", "Drinks" },
                    { 4, "nonveg.png", "Non-Veg" },
                    { 5, "pizza.png", "Pizza" },
                    { 6, "rice.png", "Rice" },
                    { 7, "seafood.png", "Seafood" },
                    { 8, "soups.png", "Soups" },
                    { 9, "veg.png", "Veg" }
                });

            migrationBuilder.InsertData(
                table: "Offer",
                columns: new[] { "Id", "BgColor", "Code", "Description", "Image", "IsActive", "MinAmount", "Name", "OfferType", "OfferedValue", "ValidTill" },
                values: new object[,]
                {
                    { 1, "Red", "OFF-50", "50 Percent off on all food items", "percent_50p.jpg", true, null, "50 Percent Off", 1, 50m, new DateTime(2023, 1, 23, 1, 23, 55, 733, DateTimeKind.Local).AddTicks(6354) },
                    { 2, "Red", "HOT-80", "Hot Offer", "hot_offer.jpg", true, null, "Hot Offer", 1, 80m, new DateTime(2023, 1, 18, 1, 23, 55, 733, DateTimeKind.Local).AddTicks(6372) },
                    { 3, "Yellow", "UPTO-25", "Upto 25% OFF", "upto_25_percent.png", true, 500m, "Upto 25% OFF", 1, 25m, null },
                    { 4, "Red", "HALF", "Half Price", "half_price.jpg", true, 1000m, "Half Price", 1, 50m, new DateTime(2023, 1, 18, 1, 23, 55, 733, DateTimeKind.Local).AddTicks(6378) },
                    { 5, "Red", "100-TODAY", "Flat Rs. 100 Off Today Only", "today_only.png", true, null, "Flat Rs. 100 Off Today Only", 0, 100m, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, "#FFFFFF", "OFF", "50", "thirty_percent.jpg", true, 300m, "30% OFF", 1, 30m, new DateTime(2023, 2, 16, 1, 23, 55, 733, DateTimeKind.Local).AddTicks(6384) },
                    { 7, "Red", "FEST-150", "Special Festival Offer", "special_offer.png", true, null, "Special Festival Offer", 0, 150m, new DateTime(2023, 1, 21, 1, 23, 55, 733, DateTimeKind.Local).AddTicks(6401) },
                    { 8, "Gray", "SALE-40", "SALE 40% OFF", "sale_40_percent.jpg", true, null, "SALE 40% OFF", 1, 40m, new DateTime(2023, 1, 20, 1, 23, 55, 733, DateTimeKind.Local).AddTicks(6402) },
                    { 9, "Red", "50-OFF", "50% OFF", "fifty_percent_off.png", true, null, "50% OFF", 1, 50m, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Offer");
        }
    }
}
