using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GProject.Data.Migrations
{
    public partial class up2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariation_Size_ColorId",
                table: "ProductVariation");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariation_SizeId",
                table: "ProductVariation",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariation_Size_SizeId",
                table: "ProductVariation",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariation_Size_SizeId",
                table: "ProductVariation");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariation_SizeId",
                table: "ProductVariation");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariation_Size_ColorId",
                table: "ProductVariation",
                column: "ColorId",
                principalTable: "Size",
                principalColumn: "Id");
        }
    }
}
