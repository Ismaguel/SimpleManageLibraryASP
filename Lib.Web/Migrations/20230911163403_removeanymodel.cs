using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lib.Web.Migrations
{
    /// <inheritdoc />
    public partial class removeanymodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_Imprint_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_ImprinterId",
                table: "BaseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_Imprinter_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_Imprint_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_Imprinter_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_ImprinterId",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "Imprint_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "ImprinterId",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "Imprinter_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "LibraryId",
                table: "BaseModel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Imprint_LibraryId",
                table: "BaseModel",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImprinterId",
                table: "BaseModel",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Imprinter_LibraryId",
                table: "BaseModel",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibraryId",
                table: "BaseModel",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_Imprint_LibraryId",
                table: "BaseModel",
                column: "Imprint_LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_Imprinter_LibraryId",
                table: "BaseModel",
                column: "Imprinter_LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_ImprinterId",
                table: "BaseModel",
                column: "ImprinterId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_LibraryId",
                table: "BaseModel",
                column: "LibraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_Imprint_LibraryId",
                table: "BaseModel",
                column: "Imprint_LibraryId",
                principalTable: "BaseModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_ImprinterId",
                table: "BaseModel",
                column: "ImprinterId",
                principalTable: "BaseModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_Imprinter_LibraryId",
                table: "BaseModel",
                column: "Imprinter_LibraryId",
                principalTable: "BaseModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_LibraryId",
                table: "BaseModel",
                column: "LibraryId",
                principalTable: "BaseModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
