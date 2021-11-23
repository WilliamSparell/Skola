using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Övning.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Power",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeroID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Power", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Power_Heroes_HeroID",
                        column: x => x.HeroID,
                        principalTable: "Heroes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Power_HeroID",
                table: "Power",
                column: "HeroID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Power");

            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
