using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWork.Models
{
    [Table("Студенты")]
    class Student
    {
        [Column("Номер зачётной книжки")]
        [Key]
        public string GradeBookNumber { get; set; }

        [Column("Фамилия")]
        [Required]
        public string Surname { get; set; }

        [Column("Имя")]
        [Required]
        public string Name { get; set; }

        [Column("Отчество")]
        [Required]
        public string Patronymic { get; set; }
        [Column("ФИО")]
        [Required]
        private string FCs { get; set; }

        [Column("Номер группы")]
        [Required]
        public string GroupNumber { get; set; }

        [Column("Курс")]
        [Required]
        public int CourseNumber { get; set; }

        [Column("Форма обучения")]
        [Required]
        public string EducationForm { get; set; }

        [Column("Номер специальности")]
        [Required]
        public string SpecialtyNumber { get; set; }

        [Column("Иностранец")]
        [Required]
        public string Foreigner{ get; set; }


    }
}
