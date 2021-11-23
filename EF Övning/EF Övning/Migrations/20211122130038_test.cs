using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Övning.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Power_Heroes_HeroID",
                table: "Power");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Power",
                table: "Power");

            migrationBuilder.RenameTable(
                name: "Power",
                newName: "Powers");

            migrationBuilder.RenameIndex(
                name: "IX_Power_HeroID",
                table: "Powers",
                newName: "IX_Powers_HeroID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Powers",
                table: "Powers",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Powers_Heroes_HeroID",
                table: "Powers",
                column: "HeroID",
                principalTable: "Heroes",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Powers_Heroes_HeroID",
                table: "Powers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Powers",
                table: "Powers");

            migrationBuilder.RenameTable(
                name: "Powers",
                newName: "Power");

            migrationBuilder.RenameIndex(
                name: "IX_Powers_HeroID",
                table: "Power",
                newName: "IX_Power_HeroID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Power",
                table: "Power",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Power_Heroes_HeroID",
                table: "Power",
                column: "HeroID",
                principalTable: "Heroes",
                principalColumn: "ID");
        }
    }
}
