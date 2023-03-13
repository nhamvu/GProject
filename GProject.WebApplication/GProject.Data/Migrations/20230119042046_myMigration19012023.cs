using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GProject.Data.Migrations
{
    public partial class myMigration19012023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Color",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SearchCount",
                table: "Brand",
                type: "nvarchar(max)",
                nullable: true,
                defaultValueSql: "((0))",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValueSql: "((0))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Color");

            migrationBuilder.AlterColumn<string>(
                name: "SearchCount",
                table: "Brand",
                type: "nvarchar(max)",
                nullable: false,
                defaultValueSql: "((0))",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValueSql: "((0))");
        }
    }
}
