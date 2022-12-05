using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class OrderItemToSku : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_SkuId",
                table: "OrderItems",
                column: "SkuId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Skus_SkuId",
                table: "OrderItems",
                column: "SkuId",
                principalTable: "Skus",
                principalColumn: "SkuId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Skus_SkuId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_SkuId",
                table: "OrderItems");
        }
    }
}
