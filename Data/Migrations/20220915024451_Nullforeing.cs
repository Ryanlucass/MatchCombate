using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Nullforeing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lutador_Lutas_FightId",
                table: "Lutador");

            migrationBuilder.AlterColumn<int>(
                name: "FightId",
                table: "Lutador",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Lutador_Lutas_FightId",
                table: "Lutador",
                column: "FightId",
                principalTable: "Lutas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lutador_Lutas_FightId",
                table: "Lutador");

            migrationBuilder.AlterColumn<int>(
                name: "FightId",
                table: "Lutador",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lutador_Lutas_FightId",
                table: "Lutador",
                column: "FightId",
                principalTable: "Lutas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
