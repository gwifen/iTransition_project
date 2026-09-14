using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class UpdateKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacancyAttributes_Vacancies_VacancyId", 
                table: "VacancyAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_VacancyAttributes_Attributes_SkillAttributeId", 
                table: "VacancyAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeLikes_Resumes_ResumeId", 
                table: "ResumeLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeLikes_AspNetUsers_UserId", 
                table: "ResumeLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeAttributeValues_Resumes_ResumeId", 
                table: "ResumeAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeAttributeValues_Attributes_SkillAttributeID", 
                table: "ResumeAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateAttributeValues_AspNetUsers_UserId",
                table: "CandidateAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateAttributeValues_Attributes_SkillAttributeId", 
                table: "CandidateAttributeValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacancyAttributes", 
                table: "VacancyAttributes");

            migrationBuilder.DropIndex(
                name: "IX_VacancyAttributes_VacancyId", 
                table: "VacancyAttributes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeLikes", 
                table: "ResumeLikes");

            migrationBuilder.DropIndex(
                name: "IX_ResumeLikes_UserId", 
                table: "ResumeLikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeAttributeValues", 
                table: "ResumeAttributeValues");

            migrationBuilder.DropIndex(
                name: "IX_ResumeAttributeValues_ResumeId", 
                table: "ResumeAttributeValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateAttributeValues", 
                table: "CandidateAttributeValues");

            migrationBuilder.DropIndex(
                name: "IX_CandidateAttributeValues_SkillAttributeId", 
                table: "CandidateAttributeValues");

            migrationBuilder.DropColumn(
                name: "Id", 
                table: "VacancyAttributes");

            migrationBuilder.DropColumn(
                name: "Id", 
                table: "ResumeLikes");

            migrationBuilder.DropColumn(
                name: "Id", 
                table: "ResumeAttributeValues");

            migrationBuilder.DropColumn(
                name: "Id", 
                table: "CandidateAttributeValues");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacancyAttributes", 
                table: "VacancyAttributes", 
                columns: new[] { "VacancyId", "SkillAttributeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeLikes", 
                table: "ResumeLikes", 
                columns: new[] { "UserId", "ResumeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeAttributeValues", 
                table: "ResumeAttributeValues", 
                columns: new[] { "ResumeId", "SkillAttributeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateAttributeValues", 
                table: "CandidateAttributeValues", 
                columns: new[] { "SkillAttributeId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_VacancyAttributes_Vacancies_VacancyId", 
                table: "VacancyAttributes",
                column: "VacancyId", 
                principalTable: "Vacancies", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacancyAttributes_Attributes_SkillAttributeId", 
                table: "VacancyAttributes", 
                column: "SkillAttributeId", 
                principalTable: "Attributes", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeLikes_Resumes_ResumeId", 
                table: "ResumeLikes", 
                column: "ResumeId", 
                principalTable: "Resumes", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeLikes_AspNetUsers_UserId", 
                table: "ResumeLikes", 
                column: "UserId", 
                principalTable: "AspNetUsers", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeAttributeValues_Resumes_ResumeId", 
                table: "ResumeAttributeValues", 
                column: "ResumeId", 
                principalTable: "Resumes", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeAttributeValues_Attributes_SkillAttributeId", 
                table: "ResumeAttributeValues", 
                column: "SkillAttributeId", 
                principalTable: "Attributes", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateAttributeValues_AspNetUsers_UserId",
                table: "CandidateAttributeValues", 
                column: "UserId", 
                principalTable: "AspNetUsers", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateAttributeValues_Attributes_SkillAttributeId", 
                table: "CandidateAttributeValues", 
                column: "SkillAttributeId", 
                principalTable: "Attributes", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacancyAttributes_Vacancies_VacancyId", 
                table: "VacancyAttributes");
            
            migrationBuilder.DropForeignKey(
                name: "FK_VacancyAttributes_Attributes_SkillAttributeId", 
                table: "VacancyAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeLikes_Resumes_ResumeId", 
                table: "ResumeLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeLikes_AspNetUsers_UserId", 
                table: "ResumeLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeAttributeValues_Resumes_ResumeId", 
                table: "ResumeAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeAttributeValues_Attributes_SkillAttributeId", 
                table: "ResumeAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateAttributeValues_AspNetUsers_UserId", 
                table: "CandidateAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateAttributeValues_Attributes_SkillAttributeId", 
                table: "CandidateAttributeValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacancyAttributes", 
                table: "VacancyAttributes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeLikes", 
                table: "ResumeLikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeAttributeValues", 
                table: "ResumeAttributeValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateAttributeValues", 
                table: "CandidateAttributeValues");

            migrationBuilder.Sql("ALTER TABLE `VacancyAttributes` ADD `Id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY;");
            
            migrationBuilder.Sql("ALTER TABLE `ResumeLikes` ADD `Id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY;");
            
            migrationBuilder.Sql("ALTER TABLE `ResumeAttributeValues` ADD `Id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY;");
            
            migrationBuilder.Sql("ALTER TABLE `CandidateAttributeValues` ADD `Id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY;");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyAttributes_VacancyId", 
                table: "VacancyAttributes", 
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeLikes_UserId", 
                table: "ResumeLikes", 
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeAttributeValues_ResumeId", 
                table: "ResumeAttributeValues", 
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateAttributeValues_SkillAttributeId", 
                table: "CandidateAttributeValues", 
                column: "SkillAttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VacancyAttributes_Vacancies_VacancyId", 
                table: "VacancyAttributes", 
                column: "VacancyId", 
                principalTable: "Vacancies", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacancyAttributes_Attributes_SkillAttributeId", 
                table: "VacancyAttributes", 
                column: "SkillAttributeId", 
                principalTable: "Attributes", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeLikes_Resumes_ResumeId", 
                table: "ResumeLikes", 
                column: "ResumeId", 
                principalTable: "Resumes", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeLikes_AspNetUsers_UserId", 
                table: "ResumeLikes", 
                column: "UserId", 
                principalTable: "AspNetUsers", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeAttributeValues_Resumes_ResumeId", 
                table: "ResumeAttributeValues", 
                column: "ResumeId", 
                principalTable: "Resumes", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeAttributeValues_Attributes_SkillAttributeId", 
                table: "ResumeAttributeValues", 
                column: "SkillAttributeId", 
                principalTable: "Attributes", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateAttributeValues_AspNetUsers_UserId", 
                table: "CandidateAttributeValues", 
                column: "UserId", 
                principalTable: "AspNetUsers", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateAttributeValues_Attributes_SkillAttributeId", 
                table: "CandidateAttributeValues",
                column: "SkillAttributeId", 
                principalTable: "Attributes", 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);
        }
    }
}
