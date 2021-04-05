using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisWork.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Практики",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Названиепрактики = table.Column<string>(name: "Название практики", type: "nvarchar(max)", nullable: false),
                    Типпрактики = table.Column<string>(name: "Тип практики", type: "nvarchar(max)", nullable: false),
                    Семестр = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Видпрактики = table.Column<string>(name: "Вид практики", type: "nvarchar(max)", nullable: false),
                    Колвонедель = table.Column<int>(name: "Кол-во недель", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Практики", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Преподаватели",
                columns: table => new
                {
                    TabNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Имя = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Фамилия = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Отчество = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ФИО = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Должность = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Учстепень = table.Column<string>(name: "Уч. степень", type: "nvarchar(max)", nullable: false),
                    Пароль = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ставка = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Штатность = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Контактныйтелефон = table.Column<string>(name: "Контактный телефон", type: "nvarchar(max)", nullable: false),
                    Звание = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Преподаватели", x => x.TabNumber);
                });

            migrationBuilder.CreateTable(
                name: "Студенты",
                columns: table => new
                {
                    Номерзачётнойкнижки = table.Column<string>(name: "Номер зачётной книжки", type: "nvarchar(450)", nullable: false),
                    Фамилия = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Имя = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Отчество = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Учгод = table.Column<DateTime>(name: "Уч. год", type: "datetime2", nullable: false),
                    Номергруппы = table.Column<string>(name: "Номер группы", type: "nvarchar(max)", nullable: false),
                    Курс = table.Column<int>(type: "int", nullable: false),
                    Отделение = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Направление = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Староста = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Студенты", x => x.Номерзачётнойкнижки);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Имя = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Фамилия = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Отчество = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ФИО = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Логин = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Пароль = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Роль = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "График практик",
                columns: table => new
                {
                    IdГрафикапрактики = table.Column<int>(name: "Id Графика практики", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdПрактики = table.Column<int>(name: "Id Практики", type: "int", nullable: false),
                    Учгод = table.Column<DateTime>(name: "Уч. год", type: "datetime2", nullable: false),
                    GroupNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Колвостудентов = table.Column<int>(name: "Кол-во студентов", type: "int", nullable: false),
                    ФИОРукПрактики = table.Column<string>(name: "ФИО Рук.Практики", type: "nvarchar(max)", nullable: false),
                    Направление = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Датаначала = table.Column<DateTime>(name: "Дата начала", type: "datetime2", nullable: false),
                    Датаконца = table.Column<DateTime>(name: "Дата конца", type: "datetime2", nullable: false),
                    Колвонедель = table.Column<int>(name: "Кол-во недель", type: "int", nullable: false),
                    ЧасыСРС = table.Column<int>(name: "Часы СРС", type: "int", nullable: false),
                    Аудиторныечасы = table.Column<int>(name: "Аудиторные часы", type: "int", nullable: false),
                    Часыназачёт = table.Column<int>(name: "Часы на зачёт", type: "int", nullable: false),
                    Лист = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_График практик", x => x.IdГрафикапрактики);
                    table.ForeignKey(
                        name: "FK_График практик_Практики_Id Практики",
                        column: x => x.IdПрактики,
                        principalTable: "Практики",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Компетенции",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ГраффикId = table.Column<int>(name: "Граффик Id", type: "int", nullable: false),
                    Квалификация = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Описание = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Компетенции", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Компетенции_График практик_Граффик Id",
                        column: x => x.ГраффикId,
                        principalTable: "График практик",
                        principalColumn: "Id Графика практики",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_График практик_Id Практики",
                table: "График практик",
                column: "Id Практики");

            migrationBuilder.CreateIndex(
                name: "IX_Компетенции_Граффик Id",
                table: "Компетенции",
                column: "Граффик Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Компетенции");

            migrationBuilder.DropTable(
                name: "Преподаватели");

            migrationBuilder.DropTable(
                name: "Студенты");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "График практик");

            migrationBuilder.DropTable(
                name: "Практики");
        }
    }
}
