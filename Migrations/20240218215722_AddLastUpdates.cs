using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__Coderhouse_MAIN.Migrations
{
    /// <inheritdoc />
    public partial class AddLastUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_UsersId",
                table: "Products",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_UsersId",
                table: "Sales",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_UsersId",
                table: "Products",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_UsersId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Products_UsersId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Products");
        }
    }
}
