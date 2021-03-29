using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisWork.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "График практик",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Учебныйгод = table.Column<int>(name: "Учебный год", type: "int", nullable: false),
                    Названиепрактики = table.Column<string>(name: "Название практики", type: "nvarchar(max)", nullable: false),
                    Семестр = table.Column<int>(type: "int", nullable: false),
                    Типпрактики = table.Column<string>(name: "Тип практики", type: "nvarchar(max)", nullable: false),
                    Номергруппы = table.Column<int>(name: "Номер группы", type: "int", nullable: false),
                    ФИОруководителя = table.Column<string>(name: "ФИО руководителя", type: "nvarchar(max)", nullable: false),
                    Направление = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Количествонедель = table.Column<string>(name: "Количество недель", type: "nvarchar(max)", nullable: false),
                    Датаначала = table.Column<DateTime>(name: "Дата начала", type: "datetime2", nullable: false),
                    Датаокончания = table.Column<DateTime>(name: "Дата окончания", type: "datetime2", nullable: false),
                    Часыназачёт = table.Column<int>(name: "Часы на зачёт", type: "int", nullable: false),
                    Часынапрактику = table.Column<int>(name: "Часы на практику", type: "int", nullable: false),
                    Формаобучения = table.Column<string>(name: "Форма обучения", type: "nvarchar(max)", nullable: false),
                    Профиль = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Курс = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Колвостудентов = table.Column<int>(name: "Кол-во студентов", type: "int", nullable: false),
                    Видпрактики = table.Column<string>(name: "Вид практики", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_График практик", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Компетенции",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Квалификация = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Описание = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Номернаправленияподготовки = table.Column<string>(name: "Номер направления подготовки ", type: "nvarchar(max)", nullable: false),
                    Названиепрофиля = table.Column<string>(name: "Название профиля", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Компетенции", x => x.Id);
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
                    Номергруппы = table.Column<string>(name: "Номер группы", type: "nvarchar(max)", nullable: false),
                    Курс = table.Column<int>(type: "int", nullable: false),
                    Формаобучения = table.Column<string>(name: "Форма обучения", type: "nvarchar(max)", nullable: false),
                    Номерспециальности = table.Column<string>(name: "Номер специальности", type: "nvarchar(max)", nullable: false),
                    Иностранец = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Студенты", x => x.Номерзачётнойкнижки);
                });

            migrationBuilder.CreateTable(
                name: "Practices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Названиекомпании = table.Column<string>(name: "Название компании", type: "nvarchar(max)", nullable: true),
                    Индекс = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Регион = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Город = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Улица = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Дом = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Номердоговора = table.Column<string>(name: "Номер договора", type: "nvarchar(max)", nullable: true),
                    Должностьруководителяпредприятия = table.Column<string>(name: "Должность руководителя предприятия", type: "nvarchar(max)", nullable: true),
                    ФИОруководителяпредприятия = table.Column<string>(name: "ФИО руководителя предприятия", type: "nvarchar(max)", nullable: true),
                    ФИООтветственнноголица = table.Column<string>(name: "ФИО Ответственнного лица", type: "nvarchar(max)", nullable: true),
                    ДолжностьОтветственнноголица = table.Column<string>(name: "Должность Ответственнного лица", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practices", x => x.Id);
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "График практик");

            migrationBuilder.DropTable(
                name: "Компетенции");

            migrationBuilder.DropTable(
                name: "Преподаватели");

            migrationBuilder.DropTable(
                name: "Студенты");

            migrationBuilder.DropTable(
                name: "Practices");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
