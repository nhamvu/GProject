using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GProject.Data.Migrations
{
    public partial class update_table_Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "DiscountRate",
                table: "Order",
                type: "real",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<int>(
                name: "VoucherId",
                table: "Order",
                type: "int",
                nullable: true,
                defaultValueSql: "((0))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountRate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "VoucherId",
                table: "Order");
        }
    }
}
