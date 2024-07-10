using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Primera.Migrations
{
    /// <inheritdoc />
    public partial class ScoredConceded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Lose = table.Column<int>(type: "int", nullable: false),
                    Draw = table.Column<int>(type: "int", nullable: false),
                    Scored = table.Column<int>(type: "int", nullable: false),
                    Conceded = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Conceded", "Draw", "Lose", "Name", "Scored", "Wins" },
                values: new object[,]
                {
                    { 1, "Madrid", 0, 0, 0, "Real Madrid", 0, 0 },
                    { 2, "Barcelona", 0, 0, 0, "Barcelona", 0, 0 },
                    { 3, "Madrid", 0, 0, 0, "Atletico Madrid", 0, 0 },
                    { 4, "Valencia", 0, 0, 0, "Valencia", 0, 0 },
                    { 5, "Sevilla", 0, 0, 0, "Sevilla", 0, 0 },
                    { 6, "San Sebastian", 0, 0, 0, "Real Sociedad", 0, 0 },
                    { 7, "Villarreal", 0, 0, 0, "Villarreal", 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
