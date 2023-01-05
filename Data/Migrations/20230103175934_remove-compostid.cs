using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class removecompostid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Lutador",
                table: "Lutador");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Lutador",
                type: "varchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldMaxLength: 11)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lutador",
                table: "Lutador",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Lutador",
                table: "Lutador");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Lutador",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldMaxLength: 11,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lutador",
                table: "Lutador",
                columns: new[] { "Id", "Cpf" });
        }
    }
}
