using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    AddressCountry = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    AddressCity = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    AddressDistrict = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    AddressZipCode = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    AddressStatus = table.Column<bool>(type: "bit", nullable: false),
                    AddressCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false),
                    CategoryCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CustomerLastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    CustomerTcId = table.Column<int>(type: "int", nullable: false),
                    CustomerBirthDate = table.Column<int>(type: "int", nullable: false),
                    CustomerGsm = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    CustomerStatus = table.Column<bool>(type: "bit", nullable: false),
                    CustomerCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkuId = table.Column<int>(type: "int", nullable: false),
                    OrderdId = table.Column<int>(type: "int", nullable: false),
                    OrderItemUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderItemQuantity = table.Column<int>(type: "int", nullable: false),
                    OrderItemStatus = table.Column<bool>(type: "bit", nullable: false),
                    OrderItemCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustemerId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    OrderTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<bool>(type: "bit", nullable: false),
                    OrderCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Skus",
                columns: table => new
                {
                    SkuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkuName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SkuDescription = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    SkuOldPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SkuPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SkuStatus = table.Column<bool>(type: "bit", nullable: false),
                    SkuCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skus", x => x.SkuId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Skus");
        }
    }
}
