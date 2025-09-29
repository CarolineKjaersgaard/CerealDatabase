using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CerealDatabase.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cereals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    mfr = table.Column<int>(type: "INTEGER", nullable: false),
                    type = table.Column<int>(type: "INTEGER", nullable: false),
                    calories = table.Column<int>(type: "INTEGER", nullable: false),
                    protein = table.Column<int>(type: "INTEGER", nullable: false),
                    fat = table.Column<int>(type: "INTEGER", nullable: false),
                    sodium = table.Column<int>(type: "INTEGER", nullable: false),
                    fiber = table.Column<float>(type: "REAL", nullable: false),
                    carbo = table.Column<float>(type: "REAL", nullable: false),
                    sugars = table.Column<int>(type: "INTEGER", nullable: false),
                    potass = table.Column<int>(type: "INTEGER", nullable: false),
                    vitamins = table.Column<int>(type: "INTEGER", nullable: false),
                    shelf = table.Column<int>(type: "INTEGER", nullable: false),
                    weight = table.Column<float>(type: "REAL", nullable: false),
                    cups = table.Column<float>(type: "REAL", nullable: false),
                    rating = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cereals", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cereals");
        }
    }
}
