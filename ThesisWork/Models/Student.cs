using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Номер зачётной книжки")]
        public string GradeBookNumber { get; set; }

        [DisplayName("Фамилия")]
        [Column("Фамилия")]
        [Required]
        
        public string Surname { get; set; }

        [DisplayName("Имя")]
        [Column("Имя")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Отчество")]
        [Column("Отчество")]
        [Required]
        public string Patronymic { get; set; }
        [DisplayName("ФИО")]
        [Column("ФИО")]
        [Required]
        private string FCs { get; set; }

        [Column("Уч. год")]
        [DisplayName("Уч. год")]
        [Required]
        public string SudtingYear { get; set; }

        [DisplayName("Номер группы")]
        [Column("Номер группы")]
        [Required]
        public string GroupNumber { get; set; }

        [DisplayName("Курс")]
        [Column("Курс")]
        [Required]
        public int CourseNumber { get; set; }

        [DisplayName("Отделение")]
        [Column("Отделение")]
        [Required]
        public string Departament { get; set; }

        [DisplayName("Направление")]
        [Column("Направление")]
        [Required]
        public string Vector { get; set; }

        [DisplayName("Староста")]
        [Column("Староста")]
        [Required]
        public bool Mentor { get; set; }




    }
}
