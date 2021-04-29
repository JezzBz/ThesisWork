﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThesisWork.Repository;

namespace ThesisWork.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210429125423_2122")]
    partial class _2122
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompetencePracticeSchedule", b =>
                {
                    b.Property<int>("CompetencesId")
                        .HasColumnType("int");

                    b.Property<int>("PracticesScheduleId")
                        .HasColumnType("int");

                    b.HasKey("CompetencesId", "PracticesScheduleId");

                    b.HasIndex("PracticesScheduleId");

                    b.ToTable("CompetencePracticeSchedule");
                });

            modelBuilder.Entity("ThesisWork.Models.Competence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ThisCompetence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Компетенция");

                    b.HasKey("Id");

                    b.ToTable("Компетенции");
                });

            modelBuilder.Entity("ThesisWork.Models.MarksReport", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EducationYear")
                        .HasColumnType("int")
                        .HasColumnName("Учебный год");

                    b.Property<string>("ExamenBookNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mark")
                        .HasColumnType("int")
                        .HasColumnName("Оценка");

                    b.HasKey("id");

                    b.ToTable("Оценочная ведомость");
                });

            modelBuilder.Entity("ThesisWork.Models.Practice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Название практики");

                    b.Property<string>("PracticeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Тип практики");

                    b.Property<string>("PracticeView")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Вид практики");

                    b.Property<string>("Semestr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Семестр");

                    b.Property<int>("WeeksNumber")
                        .HasColumnType("int")
                        .HasColumnName("Кол-во недель");

                    b.HasKey("Id");

                    b.ToTable("Практики");
                });

            modelBuilder.Entity("ThesisWork.Models.PracticeBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Регион");

                    b.Property<string>("Building")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Дом");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Город");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Название огранизации");

                    b.Property<string>("DirectorFCs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ФИО Руководителя предприятия");

                    b.Property<string>("DirectorPos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Должность руководителя предприятия");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("№ Договора ");

                    b.Property<DateTime>("EducationYear")
                        .HasColumnType("datetime2")
                        .HasColumnName("Уч. год");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Группа");

                    b.Property<string>("Index")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Индекс");

                    b.Property<int?>("PracticeScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("ResponsibleFCs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ФИО ответственного от профильной организации");

                    b.Property<string>("ResponsiblePost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Должность ответственного от профильной организации");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Улица");

                    b.Property<string>("StudentGradeBookNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudentSudtingYear")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PracticeScheduleId");

                    b.HasIndex("StudentGradeBookNumber", "StudentSudtingYear");

                    b.ToTable("PracticeBases");
                });

            modelBuilder.Entity("ThesisWork.Models.PracticeSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id Графика практики")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EducationYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Уч. год");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Дата конца");

                    b.Property<float>("ExamenHours")
                        .HasColumnType("real")
                        .HasColumnName("Часы на зачёт");

                    b.Property<string>("GroupNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("№ Группы");

                    b.Property<string>("HeadFcs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ФИО Рук.Практики");

                    b.Property<float>("HoursClass")
                        .HasColumnType("real")
                        .HasColumnName("Аудиторные часы");

                    b.Property<float>("HoursSRS")
                        .HasColumnType("real")
                        .HasColumnName("Часы СРС");

                    b.Property<float>("HoursSum")
                        .HasColumnType("real")
                        .HasColumnName("Часы на практику");

                    b.Property<int>("PracticeId")
                        .HasColumnType("int");

                    b.Property<string>("SchedulePage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Лист");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Дата начала");

                    b.Property<int>("StudentsNumber")
                        .HasColumnType("int")
                        .HasColumnName("Кол-во студентов");

                    b.Property<string>("Vector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Направление");

                    b.Property<int>("WeeksNumber")
                        .HasColumnType("int")
                        .HasColumnName("Кол-во недель");

                    b.HasKey("Id");

                    b.ToTable("График практик");
                });

            modelBuilder.Entity("ThesisWork.Models.Profile", b =>
                {
                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FGOS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ФГОС");

                    b.Property<string>("ProfileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Название профиля");

                    b.Property<string>("Vector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Направление");

                    b.HasKey("Group");

                    b.ToTable("Профиль");
                });

            modelBuilder.Entity("ThesisWork.Models.Specialty", b =>
                {
                    b.Property<string>("Vector")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Направление");

                    b.Property<string>("EducationForm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Форма обучения");

                    b.Property<string>("EducationLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Уровень образования");

                    b.Property<string>("VectorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Наименование направления");

                    b.HasKey("Vector");

                    b.ToTable("Специальности");
                });

            modelBuilder.Entity("ThesisWork.Models.Student", b =>
                {
                    b.Property<string>("GradeBookNumber")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Номер зачётной книжки");

                    b.Property<string>("SudtingYear")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Уч. год");

                    b.Property<int>("CourseNumber")
                        .HasColumnType("int")
                        .HasColumnName("Курс");

                    b.Property<string>("Departament")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Отделение");

                    b.Property<string>("GroupNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Номер группы");

                    b.Property<bool>("Mentor")
                        .HasColumnType("bit")
                        .HasColumnName("Староста");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Имя");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Отчество");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Фамилия");

                    b.Property<string>("Vector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Направление");

                    b.HasKey("GradeBookNumber", "SudtingYear");

                    b.ToTable("Студенты");
                });

            modelBuilder.Entity("ThesisWork.Models.Teacher", b =>
                {
                    b.Property<int>("TabNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcademicDegree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Уч. степень");

                    b.Property<string>("FCs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ФИО");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Имя");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Пароль");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Отчество");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Контактный телефон");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Должность");

                    b.Property<string>("Rate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ставка");

                    b.Property<string>("StaffingLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Штатность");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Фамилия");

                    b.Property<string>("TeachersTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Звание");

                    b.HasKey("TabNumber");

                    b.ToTable("Преподаватели");
                });

            modelBuilder.Entity("ThesisWork.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FCs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ФИО");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Логин");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Имя");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Пароль");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Отчество");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Роль");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Фамилия");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CompetencePracticeSchedule", b =>
                {
                    b.HasOne("ThesisWork.Models.Competence", null)
                        .WithMany()
                        .HasForeignKey("CompetencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThesisWork.Models.PracticeSchedule", null)
                        .WithMany()
                        .HasForeignKey("PracticesScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ThesisWork.Models.PracticeBase", b =>
                {
                    b.HasOne("ThesisWork.Models.PracticeSchedule", "PracticeSchedule")
                        .WithMany()
                        .HasForeignKey("PracticeScheduleId");

                    b.HasOne("ThesisWork.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentGradeBookNumber", "StudentSudtingYear");

                    b.Navigation("PracticeSchedule");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
