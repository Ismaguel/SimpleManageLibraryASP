using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lib.Web.Migrations
{
    /// <inheritdoc />
    public partial class migr4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImprinterId",
                table: "BaseModel",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_ImprinterId",
                table: "BaseModel",
                column: "ImprinterId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_ImprinterId",
                table: "BaseModel",
                column: "ImprinterId",
                principalTable: "BaseModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_ImprinterId",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_ImprinterId",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "ImprinterId",
                table: "BaseModel");
        }
    }
}
