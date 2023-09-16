using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lib.Web.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_Imprinter_ImprintId1",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_Imprinter_ImprintId1",
                table: "BaseModel");

            migrationBuilder.RenameColumn(
                name: "Imprinter_ImprintId1",
                table: "BaseModel",
                newName: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_BookId",
                table: "BaseModel",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_BookId",
                table: "BaseModel",
                column: "BookId",
                principalTable: "BaseModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_BookId",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_BookId",
                table: "BaseModel");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BaseModel",
                newName: "Imprinter_ImprintId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_Imprinter_ImprintId1",
                table: "BaseModel",
                column: "Imprinter_ImprintId1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_Imprinter_ImprintId1",
                table: "BaseModel",
                column: "Imprinter_ImprintId1",
                principalTable: "BaseModel",
                principalColumn: "Id");
        }
    }
}
