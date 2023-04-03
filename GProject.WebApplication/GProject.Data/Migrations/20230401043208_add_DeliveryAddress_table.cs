using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GProject.Data.Migrations
{
    public partial class add_DeliveryAddress_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceID = table.Column<int>(type: "int", nullable: false),
                    ProvinceName = table.Column<string>(type: "varchar(225)", unicode: false, maxLength: 225, nullable: false),
                    DistrictID = table.Column<int>(type: "int", nullable: false),
                    DistrictName = table.Column<string>(type: "varchar(225)", unicode: false, maxLength: 225, nullable: false),
                    WardCode = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    WardName = table.Column<string>(type: "varchar(225)", unicode: false, maxLength: 225, nullable: false),
                    Address = table.Column<string>(type: "varchar(225)", unicode: false, maxLength: 225, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryAddress", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryAddress");
        }
    }
}
