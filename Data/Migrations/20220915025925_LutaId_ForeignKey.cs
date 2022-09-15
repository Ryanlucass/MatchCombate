using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class LutaId_ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lutador_Lutas_LutadorId",
                table: "Lutador");

            migrationBuilder.RenameColumn(
                name: "LutadorId",
                table: "Lutador",
                newName: "LutaId");

            migrationBuilder.RenameIndex(
                name: "IX_Lutador_LutadorId",
                table: "Lutador",
                newName: "IX_Lutador_LutaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lutador_Lutas_LutaId",
                table: "Lutador",
                column: "LutaId",
                principalTable: "Lutas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lutador_Lutas_LutaId",
                table: "Lutador");

            migrationBuilder.RenameColumn(
                name: "LutaId",
                table: "Lutador",
                newName: "LutadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Lutador_LutaId",
                table: "Lutador",
                newName: "IX_Lutador_LutadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lutador_Lutas_LutadorId",
                table: "Lutador",
                column: "LutadorId",
                principalTable: "Lutas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
