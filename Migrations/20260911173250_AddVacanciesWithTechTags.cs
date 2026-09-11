using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class AddVacanciesWithTechTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VacancyId",
                table: "Attributes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TechTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechTags", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsPublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MaxProjects = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TechTagVacancy",
                columns: table => new
                {
                    TechTagsId = table.Column<int>(type: "int", nullable: false),
                    VacanciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechTagVacancy", x => new { x.TechTagsId, x.VacanciesId });
                    table.ForeignKey(
                        name: "FK_TechTagVacancy_TechTags_TechTagsId",
                        column: x => x.TechTagsId,
                        principalTable: "TechTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechTagVacancy_Vacancies_VacanciesId",
                        column: x => x.VacanciesId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VacancyAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VacancyId = table.Column<int>(type: "int", nullable: false),
                    SkillAttributeId = table.Column<int>(type: "int", nullable: false),
                    Operator = table.Column<int>(type: "int", nullable: true),
                    RuleValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacancyAttributes_Attributes_SkillAttributeId",
                        column: x => x.SkillAttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacancyAttributes_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_VacancyId",
                table: "Attributes",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_TechTagVacancy_VacanciesId",
                table: "TechTagVacancy",
                column: "VacanciesId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyAttributes_SkillAttributeId",
                table: "VacancyAttributes",
                column: "SkillAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyAttributes_VacancyId",
                table: "VacancyAttributes",
                column: "VacancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attributes_Vacancies_VacancyId",
                table: "Attributes",
                column: "VacancyId",
                principalTable: "Vacancies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attributes_Vacancies_VacancyId",
                table: "Attributes");

            migrationBuilder.DropTable(
                name: "TechTagVacancy");

            migrationBuilder.DropTable(
                name: "VacancyAttributes");

            migrationBuilder.DropTable(
                name: "TechTags");

            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_Attributes_VacancyId",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "VacancyId",
                table: "Attributes");
        }
    }
}
