using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lutas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Local = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Octogono = table.Column<string>(type: "nvarchar(23)", maxLength: 23, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lutas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Lutador",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    criado_em = table.Column<DateTime>(type: "datetime2", nullable: true),
                    nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    apelido = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    peso = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    FightId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lutador", x => x.id);
                    table.ForeignKey(
                        name: "FK_Lutador_Lutas_FightId",
                        column: x => x.FightId,
                        principalTable: "Lutas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lutador_FightId",
                table: "Lutador",
                column: "FightId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lutador");

            migrationBuilder.DropTable(
                name: "Lutas");
        }
    }
}
