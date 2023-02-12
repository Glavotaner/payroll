using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollApp.Migrations
{
    /// <inheritdoc />
    public partial class SumColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContributionsFromPay",
                table: "Payroll");

            migrationBuilder.DropColumn(
                name: "ContributionsOther",
                table: "Payroll");

            migrationBuilder.DropColumn(
                name: "ReimbursementsAmount",
                table: "Payroll");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ContributionsFromPay",
                table: "Payroll",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ContributionsOther",
                table: "Payroll",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ReimbursementsAmount",
                table: "Payroll",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
