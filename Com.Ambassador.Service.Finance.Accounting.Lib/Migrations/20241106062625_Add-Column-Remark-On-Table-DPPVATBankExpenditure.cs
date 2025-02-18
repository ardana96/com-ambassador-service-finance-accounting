using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.Migrations
{
    public partial class AddColumnRemarkOnTableDPPVATBankExpenditure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DiffAmount",
                table: "GarmentInvoicePurchasingDispositions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "DiffRemark",
                table: "GarmentInvoicePurchasingDispositions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "DPPVATBankExpenditureNotes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiffAmount",
                table: "GarmentInvoicePurchasingDispositions");

            migrationBuilder.DropColumn(
                name: "DiffRemark",
                table: "GarmentInvoicePurchasingDispositions");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "DPPVATBankExpenditureNotes");
        }
    }
}
