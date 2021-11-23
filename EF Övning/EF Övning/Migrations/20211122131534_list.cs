using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Övning.Migrations
{
    public partial class list : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Powers_Heroes_HeroID",
                table: "Powers");

            migrationBuilder.DropIndex(
                name: "IX_Powers_HeroID",
                table: "Powers");

            migrationBuilder.DropColumn(
                name: "HeroID",
                table: "Powers");

            migrationBuilder.CreateTable(
                name: "HeroPower",
                columns: table => new
                {
                    HeroesID = table.Column<int>(type: "int", nullable: false),
                    PowersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroPower", x => new { x.HeroesID, x.PowersID });
                    table.ForeignKey(
                        name: "FK_HeroPower_Heroes_HeroesID",
                        column: x => x.HeroesID,
                        principalTable: "Heroes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroPower_Powers_PowersID",
                        column: x => x.PowersID,
                        principalTable: "Powers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroPower_PowersID",
                table: "HeroPower",
                column: "PowersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroPower");

            migrationBuilder.AddColumn<int>(
                name: "HeroID",
                table: "Powers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Powers_HeroID",
                table: "Powers",
                column: "HeroID");

            migrationBuilder.AddForeignKey(
                name: "FK_Powers_Heroes_HeroID",
                table: "Powers",
                column: "HeroID",
                principalTable: "Heroes",
                principalColumn: "ID");
        }
    }
}
