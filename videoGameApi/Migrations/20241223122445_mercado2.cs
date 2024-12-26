using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace videoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class mercado2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdMercado",
                table: "VideoGames");

            migrationBuilder.RenameColumn(
                name: "Mercado",
                table: "VideoGameMercado",
                newName: "NombreMercado");

            migrationBuilder.AddColumn<int>(
                name: "IdVideoGameMercado",
                table: "VideoGames",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdVideoGameVersion",
                table: "VideoGames",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VideoGameVersion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoGameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGameVersion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoGameVersion_VideoGames_VideoGameId",
                        column: x => x.VideoGameId,
                        principalTable: "VideoGames",
                        principalColumn: "VideoGameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 1,
                columns: new[] { "IdVideoGameMercado", "IdVideoGameVersion" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 2,
                columns: new[] { "IdVideoGameMercado", "IdVideoGameVersion" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 3,
                columns: new[] { "IdVideoGameMercado", "IdVideoGameVersion" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 4,
                columns: new[] { "IdVideoGameMercado", "IdVideoGameVersion" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_VideoGameVersion_VideoGameId",
                table: "VideoGameVersion",
                column: "VideoGameId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGameVersion");

            migrationBuilder.DropColumn(
                name: "IdVideoGameMercado",
                table: "VideoGames");

            migrationBuilder.DropColumn(
                name: "IdVideoGameVersion",
                table: "VideoGames");

            migrationBuilder.RenameColumn(
                name: "NombreMercado",
                table: "VideoGameMercado",
                newName: "Mercado");

            migrationBuilder.AddColumn<int>(
                name: "IdMercado",
                table: "VideoGames",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
