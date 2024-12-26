using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace videoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class Accesories2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoGames_VideoGameAccesories_videoGameAccesorysVideoGameAccesoriesId",
                table: "VideoGames");

            migrationBuilder.DropColumn(
                name: "VideoGameAccesoryID",
                table: "VideoGames");

            migrationBuilder.RenameColumn(
                name: "videoGameAccesorysVideoGameAccesoriesId",
                table: "VideoGames",
                newName: "VideoGameAccesoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_VideoGames_videoGameAccesorysVideoGameAccesoriesId",
                table: "VideoGames",
                newName: "IX_VideoGames_VideoGameAccesoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGames_VideoGameAccesories_VideoGameAccesoriesId",
                table: "VideoGames",
                column: "VideoGameAccesoriesId",
                principalTable: "VideoGameAccesories",
                principalColumn: "VideoGameAccesoriesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoGames_VideoGameAccesories_VideoGameAccesoriesId",
                table: "VideoGames");

            migrationBuilder.RenameColumn(
                name: "VideoGameAccesoriesId",
                table: "VideoGames",
                newName: "videoGameAccesorysVideoGameAccesoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_VideoGames_VideoGameAccesoriesId",
                table: "VideoGames",
                newName: "IX_VideoGames_videoGameAccesorysVideoGameAccesoriesId");

            migrationBuilder.AddColumn<int>(
                name: "VideoGameAccesoryID",
                table: "VideoGames",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 1,
                column: "VideoGameAccesoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 2,
                column: "VideoGameAccesoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 3,
                column: "VideoGameAccesoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 4,
                column: "VideoGameAccesoryID",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGames_VideoGameAccesories_videoGameAccesorysVideoGameAccesoriesId",
                table: "VideoGames",
                column: "videoGameAccesorysVideoGameAccesoriesId",
                principalTable: "VideoGameAccesories",
                principalColumn: "VideoGameAccesoriesId");
        }
    }
}
