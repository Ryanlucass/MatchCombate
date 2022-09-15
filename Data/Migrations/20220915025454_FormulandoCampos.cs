using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class FormulandoCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lutador_Lutas_FightId",
                table: "Lutador");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Lutas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "peso",
                table: "Lutador",
                newName: "Peso");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Lutador",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "criado_em",
                table: "Lutador",
                newName: "Criado_em");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Lutador",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "apelido",
                table: "Lutador",
                newName: "Apelido");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Lutador",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FightId",
                table: "Lutador",
                newName: "LutadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Lutador_FightId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lutador_Lutas_LutadorId",
                table: "Lutador");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Lutas",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Peso",
                table: "Lutador",
                newName: "peso");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Lutador",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Criado_em",
                table: "Lutador",
                newName: "criado_em");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Lutador",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Apelido",
                table: "Lutador",
                newName: "apelido");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Lutador",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "LutadorId",
                table: "Lutador",
                newName: "FightId");

            migrationBuilder.RenameIndex(
                name: "IX_Lutador_LutadorId",
                table: "Lutador",
                newName: "IX_Lutador_FightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lutador_Lutas_FightId",
                table: "Lutador",
                column: "FightId",
                principalTable: "Lutas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
