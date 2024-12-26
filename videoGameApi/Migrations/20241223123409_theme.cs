using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace videoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class theme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VideGameThemeId",
                table: "VideoGames",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VideoGameTheme",
                columns: table => new
                {
                    VideoGameThemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoGameThemeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoGameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGameTheme", x => x.VideoGameThemeId);
                });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 1,
                column: "VideGameThemeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 2,
                column: "VideGameThemeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 3,
                column: "VideGameThemeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 4,
                column: "VideGameThemeId",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoGames_VideoGameTheme_VideGameThemeId",
                table: "VideoGames");

            migrationBuilder.DropTable(
                name: "VideoGameTheme");

            migrationBuilder.DropIndex(
                name: "IX_VideoGames_VideGameThemeId",
                table: "VideoGames");

            migrationBuilder.DropColumn(
                name: "VideGameThemeId",
                table: "VideoGames");
        }
    }
}
