using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSkillAttributeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeOptions_Attributes_JobAttributeId",
                table: "AttributeOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateAttributeValues_Attributes_JobAttributeId",
                table: "CandidateAttributeValues");

            migrationBuilder.RenameColumn(
                name: "JobAttributeId",
                table: "CandidateAttributeValues",
                newName: "SkillAttributeId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateAttributeValues_JobAttributeId",
                table: "CandidateAttributeValues",
                newName: "IX_CandidateAttributeValues_SkillAttributeId");

            migrationBuilder.RenameColumn(
                name: "JobAttributeId",
                table: "AttributeOptions",
                newName: "SkillAttributeId");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeOptions_JobAttributeId",
                table: "AttributeOptions",
                newName: "IX_AttributeOptions_SkillAttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeOptions_Attributes_SkillAttributeId",
                table: "AttributeOptions",
                column: "SkillAttributeId",
                principalTable: "Attributes",
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
                name: "FK_AttributeOptions_Attributes_SkillAttributeId",
                table: "AttributeOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateAttributeValues_Attributes_SkillAttributeId",
                table: "CandidateAttributeValues");

            migrationBuilder.RenameColumn(
                name: "SkillAttributeId",
                table: "CandidateAttributeValues",
                newName: "JobAttributeId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateAttributeValues_SkillAttributeId",
                table: "CandidateAttributeValues",
                newName: "IX_CandidateAttributeValues_JobAttributeId");

            migrationBuilder.RenameColumn(
                name: "SkillAttributeId",
                table: "AttributeOptions",
                newName: "JobAttributeId");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeOptions_SkillAttributeId",
                table: "AttributeOptions",
                newName: "IX_AttributeOptions_JobAttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeOptions_Attributes_JobAttributeId",
                table: "AttributeOptions",
                column: "JobAttributeId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateAttributeValues_Attributes_JobAttributeId",
                table: "CandidateAttributeValues",
                column: "JobAttributeId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
