using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace videoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class Generos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoGameGenero",
                columns: table => new
                {
                    VideoGameGeneroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGameGenero", x => x.VideoGameGeneroId);
                });

            migrationBuilder.CreateTable(
                name: "VideoGameVideoGameGenero",
                columns: table => new
                {
                    VideoGamesVideoGameId = table.Column<int>(type: "int", nullable: false),
                    videoGameGenerosVideoGameGeneroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGameVideoGameGenero", x => new { x.VideoGamesVideoGameId, x.videoGameGenerosVideoGameGeneroId });
                    table.ForeignKey(
                        name: "FK_VideoGameVideoGameGenero_VideoGameGenero_videoGameGenerosVideoGameGeneroId",
                        column: x => x.videoGameGenerosVideoGameGeneroId,
                        principalTable: "VideoGameGenero",
                        principalColumn: "VideoGameGeneroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoGameVideoGameGenero_VideoGames_VideoGamesVideoGameId",
                        column: x => x.VideoGamesVideoGameId,
                        principalTable: "VideoGames",
                        principalColumn: "VideoGameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideoGameVideoGameGenero_videoGameGenerosVideoGameGeneroId",
                table: "VideoGameVideoGameGenero",
                column: "videoGameGenerosVideoGameGeneroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGameVideoGameGenero");

            migrationBuilder.DropTable(
                name: "VideoGameGenero");
        }
    }
}
