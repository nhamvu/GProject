using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GProject.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WardName",
                table: "DeliveryAddress",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(225)",
                oldUnicode: false,
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceName",
                table: "DeliveryAddress",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(225)",
                oldUnicode: false,
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DeliveryAddress",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(225)",
                oldUnicode: false,
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "DistrictName",
                table: "DeliveryAddress",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(225)",
                oldUnicode: false,
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "DeliveryAddress",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(225)",
                oldUnicode: false,
                oldMaxLength: 225);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WardName",
                table: "DeliveryAddress",
                type: "varchar(225)",
                unicode: false,
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceName",
                table: "DeliveryAddress",
                type: "varchar(225)",
                unicode: false,
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DeliveryAddress",
                type: "varchar(225)",
                unicode: false,
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "DistrictName",
                table: "DeliveryAddress",
                type: "varchar(225)",
                unicode: false,
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "DeliveryAddress",
                type: "varchar(225)",
                unicode: false,
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225);
        }
    }
}
