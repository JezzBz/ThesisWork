using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisWork.Migrations
{
    public partial class _212 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompetenceKey",
                table: "График практик");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompetenceKey",
                table: "График практик",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
