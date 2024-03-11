using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class fk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Documents_IdCategorie",
                table: "Documents",
                column: "IdCategorie");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_IdType",
                table: "Documents",
                column: "IdType");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Categories_IdCategorie",
                table: "Documents",
                column: "IdCategorie",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_types_IdType",
                table: "Documents",
                column: "IdType",
                principalTable: "types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Categories_IdCategorie",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_types_IdType",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_IdCategorie",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_IdType",
                table: "Documents");
        }
    }
}
