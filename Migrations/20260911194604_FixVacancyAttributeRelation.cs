using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class FixVacancyAttributeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attributes_Vacancies_VacancyId",
                table: "Attributes");

            migrationBuilder.DropIndex(
                name: "IX_Attributes_VacancyId",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "VacancyId",
                table: "Attributes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VacancyId",
                table: "Attributes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_VacancyId",
                table: "Attributes",
                column: "VacancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attributes_Vacancies_VacancyId",
                table: "Attributes",
                column: "VacancyId",
                principalTable: "Vacancies",
                principalColumn: "Id");
        }
    }
}
