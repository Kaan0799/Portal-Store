using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class SkuToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Skus_CategoryId",
                table: "Skus",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skus_Categories_CategoryId",
                table: "Skus",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skus_Categories_CategoryId",
                table: "Skus");

            migrationBuilder.DropIndex(
                name: "IX_Skus_CategoryId",
                table: "Skus");
        }
    }
}
