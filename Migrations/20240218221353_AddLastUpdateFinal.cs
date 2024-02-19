using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__Coderhouse_MAIN.Migrations
{
    /// <inheritdoc />
    public partial class AddLastUpdateFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SalesId",
                table: "Sales",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SalesId",
                table: "Sales",
                column: "SalesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Sales_SalesId",
                table: "Sales",
                column: "SalesId",
                principalTable: "Sales",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Sales_SalesId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_SalesId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "SalesId",
                table: "Sales");
        }
    }
}
