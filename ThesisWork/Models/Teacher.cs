using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWork.Models
{
    [Table("Преподаватели")]
    class Teacher
    {
        [Key]
        [Required]
        public int TabNumber { get; set; }
       
        [Column("Имя")]
        [Required]
        public string Name { get; set; }

        [Column("Фамилия")]
        [Required]
        public string Surname { get; set; }

        [Column("Отчество")]
        [Required]
        public string Patronymic { get; set; }

        [Column("ФИО")]
        [Required]
        public string FCs { get; set; }

        [Column("Должность")]
        [Required]
        public string Post { get; set; }

        [Column("Уч. степень")]
        [Required]
        public string AcademicDegree { get; set; }
        [Column("Пароль")]
        [Required]
        public string Password { get; set; }

        [Column("Ставка")]
        [Required]
        public string Rate { get; set; }
        [Column("Штатность")]
        [Required]
        public string StaffingLevel { get; set; }
        [Column("Контактный телефон")]
        [Required]
        public string PhoneNumber { get; set; }
        [Column("Звание")]
        [Required]
        public string TeachersTitle { get; set; }
    }
}
