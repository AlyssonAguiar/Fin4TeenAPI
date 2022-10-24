using Microsoft.EntityFrameworkCore.Migrations;

namespace Fin4teenAPI.Migrations
{
    public partial class CreatTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id_book = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pages = table.Column<int>(type: "int", nullable: false),
                    releaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlAmazon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id_movie = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time = table.Column<int>(type: "int", nullable: false),
                    releaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlNetflix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlAmazon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlApple = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "TvShows",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id_TvShow = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time = table.Column<int>(type: "int", nullable: false),
                    releaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlNetflix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlAmazon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlApple = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShows", x => x.name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "TvShows");
        }
    }
}
