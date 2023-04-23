using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GProject.Data.Migrations
{
    public partial class updateEntityVoucher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaximumDiscount",
                table: "Vouchers",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaximumDiscount",
                table: "Vouchers");
        }
    }
}
