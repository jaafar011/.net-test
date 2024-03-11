using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class ede : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_documents_categories_CategorieId",
                table: "documents");

            migrationBuilder.DropForeignKey(
                name: "FK_documents_types_TypessId",
                table: "documents");

            migrationBuilder.DropIndex(
                name: "IX_documents_CategorieId",
                table: "documents");

            migrationBuilder.DropIndex(
                name: "IX_documents_TypessId",
                table: "documents");

            migrationBuilder.DropColumn(
                name: "CategorieId",
                table: "documents");

            migrationBuilder.DropColumn(
                name: "TypessId",
                table: "documents");

            migrationBuilder.CreateIndex(
                name: "IX_documents_IdCategorie",
                table: "documents",
                column: "IdCategorie");

            migrationBuilder.CreateIndex(
                name: "IX_documents_IdType",
                table: "documents",
                column: "IdType");

            migrationBuilder.AddForeignKey(
                name: "FK_documents_categories_IdCategorie",
                table: "documents",
                column: "IdCategorie",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_documents_types_IdType",
                table: "documents",
                column: "IdType",
                principalTable: "types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_documents_categories_IdCategorie",
                table: "documents");

            migrationBuilder.DropForeignKey(
                name: "FK_documents_types_IdType",
                table: "documents");

            migrationBuilder.DropIndex(
                name: "IX_documents_IdCategorie",
                table: "documents");

            migrationBuilder.DropIndex(
                name: "IX_documents_IdType",
                table: "documents");

            migrationBuilder.AddColumn<int>(
                name: "CategorieId",
                table: "documents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypessId",
                table: "documents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_documents_CategorieId",
                table: "documents",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_documents_TypessId",
                table: "documents",
                column: "TypessId");

            migrationBuilder.AddForeignKey(
                name: "FK_documents_categories_CategorieId",
                table: "documents",
                column: "CategorieId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_documents_types_TypessId",
                table: "documents",
                column: "TypessId",
                principalTable: "types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
