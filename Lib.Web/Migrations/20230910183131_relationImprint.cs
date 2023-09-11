using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lib.Web.Migrations
{
    /// <inheritdoc />
    public partial class relationImprint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_BookId",
                table: "BaseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_EmprinteurId",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_EmprinteurId",
                table: "BaseModel");

            migrationBuilder.RenameColumn(
                name: "EmprinteurId",
                table: "BaseModel",
                newName: "Imprinter_ImprintId1");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BaseModel",
                newName: "Imprinter_ImprintId");

            migrationBuilder.RenameIndex(
                name: "IX_BaseModel_BookId",
                table: "BaseModel",
                newName: "IX_BaseModel_Imprinter_ImprintId");

            migrationBuilder.AddColumn<int>(
                name: "ImprintId",
                table: "BaseModel",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImprintId1",
                table: "BaseModel",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_Imprinter_ImprintId1",
                table: "BaseModel",
                column: "Imprinter_ImprintId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_ImprintId",
                table: "BaseModel",
                column: "ImprintId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_ImprintId1",
                table: "BaseModel",
                column: "ImprintId1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_ImprintId",
                table: "BaseModel",
                column: "ImprintId",
                principalTable: "BaseModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_ImprintId1",
                table: "BaseModel",
                column: "ImprintId1",
                principalTable: "BaseModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_Imprinter_ImprintId",
                table: "BaseModel",
                column: "Imprinter_ImprintId",
                principalTable: "BaseModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_Imprinter_ImprintId1",
                table: "BaseModel",
                column: "Imprinter_ImprintId1",
                principalTable: "BaseModel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_ImprintId",
                table: "BaseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_ImprintId1",
                table: "BaseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_Imprinter_ImprintId",
                table: "BaseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_Imprinter_ImprintId1",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_Imprinter_ImprintId1",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_ImprintId",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_ImprintId1",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "ImprintId",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "ImprintId1",
                table: "BaseModel");

            migrationBuilder.RenameColumn(
                name: "Imprinter_ImprintId1",
                table: "BaseModel",
                newName: "EmprinteurId");

            migrationBuilder.RenameColumn(
                name: "Imprinter_ImprintId",
                table: "BaseModel",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BaseModel_Imprinter_ImprintId",
                table: "BaseModel",
                newName: "IX_BaseModel_BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_EmprinteurId",
                table: "BaseModel",
                column: "EmprinteurId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_BookId",
                table: "BaseModel",
                column: "BookId",
                principalTable: "BaseModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_EmprinteurId",
                table: "BaseModel",
                column: "EmprinteurId",
                principalTable: "BaseModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
