using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.Migrations
{
    public partial class IsPostedExpenditure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPosted",
                table: "OthersExpenditureProofDocuments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPosted",
                table: "OthersExpenditureProofDocuments");
        }
    }
}
