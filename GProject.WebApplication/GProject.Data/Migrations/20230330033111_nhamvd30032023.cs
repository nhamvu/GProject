using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GProject.Data.Migrations
{
    public partial class nhamvd30032023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Evaluate",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evaluate_CustomerId",
                table: "Evaluate",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluate_Customer_CustomerId",
                table: "Evaluate",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluate_Customer_CustomerId",
                table: "Evaluate");

            migrationBuilder.DropIndex(
                name: "IX_Evaluate_CustomerId",
                table: "Evaluate");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Evaluate");
        }
    }
}
