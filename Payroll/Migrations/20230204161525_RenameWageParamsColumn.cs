using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollApp.Migrations
{
    /// <inheritdoc />
    public partial class RenameWageParamsColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Personal",
                table: "Deductible",
                newName: "PersonalCoefficient");

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "Payroll",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Payroll",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "Payroll");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Payroll");

            migrationBuilder.RenameColumn(
                name: "PersonalCoefficient",
                table: "Deductible",
                newName: "Personal");
        }
    }
}
