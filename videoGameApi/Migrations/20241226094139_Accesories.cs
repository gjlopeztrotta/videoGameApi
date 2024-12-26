using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace videoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class Accesories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoGames_VideoGameTheme_VideGameThemeId",
                table: "VideoGames");

            migrationBuilder.DropIndex(
                name: "IX_VideoGames_VideGameThemeId",
                table: "VideoGames");

            migrationBuilder.AddColumn<int>(
                name: "VideoGameAccesoryID",
                table: "VideoGames",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "videoGameAccesorysVideoGameAccesoriesId",
                table: "VideoGames",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VideoGameAccesories",
                columns: table => new
                {
                    VideoGameAccesoriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoGameAccesoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoGameAccesoryPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGameAccesories", x => x.VideoGameAccesoriesId);
                });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 1,
                columns: new[] { "VideoGameAccesoryID", "videoGameAccesorysVideoGameAccesoriesId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 2,
                columns: new[] { "VideoGameAccesoryID", "videoGameAccesorysVideoGameAccesoriesId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 3,
                columns: new[] { "VideoGameAccesoryID", "videoGameAccesorysVideoGameAccesoriesId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 4,
                columns: new[] { "VideoGameAccesoryID", "videoGameAccesorysVideoGameAccesoriesId" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_VideoGameTheme_VideoGameId",
                table: "VideoGameTheme",
                column: "VideoGameId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VideoGames_videoGameAccesorysVideoGameAccesoriesId",
                table: "VideoGames",
                column: "videoGameAccesorysVideoGameAccesoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGames_VideoGameAccesories_videoGameAccesorysVideoGameAccesoriesId",
                table: "VideoGames",
                column: "videoGameAccesorysVideoGameAccesoriesId",
                principalTable: "VideoGameAccesories",
                principalColumn: "VideoGameAccesoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGameTheme_VideoGames_VideoGameId",
                table: "VideoGameTheme",
                column: "VideoGameId",
                principalTable: "VideoGames",
                principalColumn: "VideoGameId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoGames_VideoGameAccesories_videoGameAccesorysVideoGameAccesoriesId",
                table: "VideoGames");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoGameTheme_VideoGames_VideoGameId",
                table: "VideoGameTheme");

            migrationBuilder.DropTable(
                name: "VideoGameAccesories");

            migrationBuilder.DropIndex(
                name: "IX_VideoGameTheme_VideoGameId",
                table: "VideoGameTheme");

            migrationBuilder.DropIndex(
                name: "IX_VideoGames_videoGameAccesorysVideoGameAccesoriesId",
                table: "VideoGames");

            migrationBuilder.DropColumn(
                name: "VideoGameAccesoryID",
                table: "VideoGames");

            migrationBuilder.DropColumn(
                name: "videoGameAccesorysVideoGameAccesoriesId",
                table: "VideoGames");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGames_VideGameThemeId",
                table: "VideoGames",
                column: "VideGameThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGames_VideoGameTheme_VideGameThemeId",
                table: "VideoGames",
                column: "VideGameThemeId",
                principalTable: "VideoGameTheme",
                principalColumn: "VideoGameThemeId");
        }
    }
}
