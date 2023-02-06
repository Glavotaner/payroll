using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollApp.Migrations
{
    /// <inheritdoc />
    public partial class ContributionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContributionRate_ContributionsModel_ContributionsModelId",
                table: "ContributionRate");

            migrationBuilder.DropIndex(
                name: "IX_ContributionRate_ContributionsModelId",
                table: "ContributionRate");

            migrationBuilder.DropColumn(
                name: "ContributionsModelId",
                table: "ContributionRate");

            migrationBuilder.CreateTable(
                name: "ContributionRateContributionsModel",
                columns: table => new
                {
                    ContributionRatesId = table.Column<int>(type: "int", nullable: false),
                    ContributionsModelsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContributionRateContributionsModel", x => new { x.ContributionRatesId, x.ContributionsModelsId });
                    table.ForeignKey(
                        name: "FK_ContributionRateContributionsModel_ContributionRate_ContributionRatesId",
                        column: x => x.ContributionRatesId,
                        principalTable: "ContributionRate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContributionRateContributionsModel_ContributionsModel_ContributionsModelsId",
                        column: x => x.ContributionsModelsId,
                        principalTable: "ContributionsModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContributionRateContributionsModel_ContributionsModelsId",
                table: "ContributionRateContributionsModel",
                column: "ContributionsModelsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContributionRateContributionsModel");

            migrationBuilder.AddColumn<int>(
                name: "ContributionsModelId",
                table: "ContributionRate",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContributionRate_ContributionsModelId",
                table: "ContributionRate",
                column: "ContributionsModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContributionRate_ContributionsModel_ContributionsModelId",
                table: "ContributionRate",
                column: "ContributionsModelId",
                principalTable: "ContributionsModel",
                principalColumn: "Id");
        }
    }
}
