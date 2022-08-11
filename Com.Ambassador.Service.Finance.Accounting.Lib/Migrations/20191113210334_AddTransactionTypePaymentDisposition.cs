using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.Migrations
{
    public partial class AddTransactionTypePaymentDisposition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransactionType",
                table: "PaymentDispositionNotes",
                maxLength: 64,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionType",
                table: "PaymentDispositionNotes");
        }
    }
}
