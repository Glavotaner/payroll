using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollApp.Migrations
{
    /// <inheritdoc />
    public partial class Address : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bank_Address_AddressId",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Bank",
                newName: "StreetId");

            migrationBuilder.RenameIndex(
                name: "IX_Bank_AddressId",
                table: "Bank",
                newName: "IX_Bank_StreetId");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Bank",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_Address_StreetId",
                table: "Bank",
                column: "StreetId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bank_Address_StreetId",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Bank");

            migrationBuilder.RenameColumn(
                name: "StreetId",
                table: "Bank",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Bank_StreetId",
                table: "Bank",
                newName: "IX_Bank_AddressId");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Address",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_Address_AddressId",
                table: "Bank",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
