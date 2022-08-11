using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.Migrations
{
    public partial class VBRequestInklaring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInklaring",
                table: "VBRequestDocuments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInklaring",
                table: "VBRequestDocuments");
        }
    }
}
