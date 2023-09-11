using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lib.Web.Migrations
{
    /// <inheritdoc />
    public partial class libbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LibraryId",
                table: "BaseModel",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_LibraryId",
                table: "BaseModel",
                column: "LibraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_LibraryId",
                table: "BaseModel",
                column: "LibraryId",
                principalTable: "BaseModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_LibraryId",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "LibraryId",
                table: "BaseModel");
        }
    }
}
