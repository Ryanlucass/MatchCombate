using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class chavecomposta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Lutador",
                table: "Lutador");

            migrationBuilder.AlterColumn<string>(
                name: "Apelido",
                table: "Lutador",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lutador",
                table: "Lutador",
                columns: new[] { "Id", "Cpf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Lutador",
                table: "Lutador");

            migrationBuilder.AlterColumn<string>(
                name: "Apelido",
                table: "Lutador",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lutador",
                table: "Lutador",
                column: "Id");
        }
    }
}
