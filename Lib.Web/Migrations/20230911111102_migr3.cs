using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lib.Web.Migrations
{
    /// <inheritdoc />
    public partial class migr3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Imprint_LibraryId",
                table: "BaseModel",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Imprinter_LibraryId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_Imprint_LibraryId",
                table: "BaseModel",
                column: "Imprint_LibraryId",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_Imprint_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_Imprinter_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_Imprint_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_Imprinter_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "Imprint_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "Imprinter_LibraryId",
                table: "BaseModel");
        }
    }
}
