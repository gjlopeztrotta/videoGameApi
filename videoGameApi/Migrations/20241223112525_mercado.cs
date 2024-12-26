using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace videoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class mercado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMercado",
                table: "VideoGames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "VideoGameMercado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mercado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoGameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGameMercado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoGameMercado_VideoGames_VideoGameId",
                        column: x => x.VideoGameId,
                        principalTable: "VideoGames",
                        principalColumn: "VideoGameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 1,
                column: "IdMercado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 2,
                column: "IdMercado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 3,
                column: "IdMercado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 4,
                column: "IdMercado",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VideoGameMercado_VideoGameId",
                table: "VideoGameMercado",
                column: "VideoGameId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGameMercado");

            migrationBuilder.DropColumn(
                name: "IdMercado",
                table: "VideoGames");
        }
    }
}
