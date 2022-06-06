using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoWebVideoGames.Migrations
{
    public partial class ReviewGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Games_GamesId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_GamesId",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "GamesId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GamesId",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Review_GamesId",
                table: "Review",
                column: "GamesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Games_GamesId",
                table: "Review",
                column: "GamesId",
                principalTable: "Games",
                principalColumn: "Id");
        }
    }
}
