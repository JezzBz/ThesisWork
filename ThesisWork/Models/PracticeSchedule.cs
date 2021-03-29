using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWork.Models
{   [Table("График практик")]
    class PracticeSchedule
    {
        [Key]
        public int Id { get; set; }
        [Column("Учебный год")]
        [Required]
        public int Year { get; set; }

        [Column("Название практики")]
        [Required]
        public string PracticeName { get; set; }

        [Column("Семестр")]
        [Required]
        public int Semester { get; set; }

        [Column("Тип практики")]
        [Required]
        public string PracticeType { get; set; }

        [Column("Номер группы")]
        [Required]
        public int GroupNumber{ get; set; }

        [Column("ФИО руководителя")]
        [Required]
        public string DirectorFcs{ get; set; }

        [Column("Направление")]
        [Required]
        public string Vector{ get; set; }

        [Column("Количество недель")]
        [Required]
        public string Duration { get; set; }

        [Column("Дата начала")]
        [Required]
        public DateTime StartDate { get; set; }

        [Column("Дата окончания")]
        [Required]
        public DateTime FinishDate { get; set; }

        [Column("Часы на зачёт")]
        [Required]
        public int ExamenHours { get; set; }

        [Column("Часы на практику")]
        public int PracticeHours { get; set; }

        [Column("Форма обучения")]
        [Required]
        public string EducationForm { get; set; }

        [Column("Профиль")]
        [Required]
        public string Profile { get; set; }
        [Column("Курс")]
        [Required]
        public string Course { get; set; }
        [Column("Кол-во студентов")]
        [Required]
        public int StudentsNumber { get; set; }
        [Column("Вид практики")]
        [Required]
        public string PracticeKind { get; set; }

    }
}
