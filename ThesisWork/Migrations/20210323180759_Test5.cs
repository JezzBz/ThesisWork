using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisWork.Migrations
{
    public partial class Test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Practices",
                table: "Practices");

            migrationBuilder.RenameTable(
                name: "Practices",
                newName: "Практики");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Практики",
                table: "Практики",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Практики",
                table: "Практики");

            migrationBuilder.RenameTable(
                name: "Практики",
                newName: "Practices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Practices",
                table: "Practices",
                column: "Id");
        }
    }
}
