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
    [Table("Преподаватели")]
    class Teacher
    {
        [Key]
        [Required]
        [DisplayName("Табличный номер")]
        public int TabNumber { get; set; }
       
        [Column("Имя")]
        [DisplayName("Имя")]
        [Required]
        public string Name { get; set; }

        [Column("Фамилия")]
        [DisplayName("Фамилия")]
        [Required]
        public string Surname { get; set; }

        [Column("Отчество")]
        [DisplayName("Отчество")]
        [Required]
        public string Patronymic { get; set; }

        [Column("ФИО")]
        [DisplayName("ФИО")]
        [Required]
        public string FCs { get; set; }

        [Column("Должность")]
        [DisplayName("Должность")]
        [Required]
        public string Post { get; set; }

        [Column("Уч. степень")]
        [DisplayName("Уч. степень")]
        [Required]
        public string AcademicDegree { get; set; }
        [Column("Пароль")]
        [DisplayName("Пароль")]
        [Required]
        public string Password { get; set; }

        [DisplayName("Ставка")]
        [Column("Ставка")]
        [Required]
        public string Rate { get; set; }
        [DisplayName("Штатность")]
        [Column("Штатность")]
        [Required]
        public string StaffingLevel { get; set; }
        [Column("Контактный телефон")]
        [DisplayName("Контактный телефон")]
        [Required]
        public string PhoneNumber { get; set; }
        [Column("Звание")]
        [DisplayName("Звание")]
        [Required]
        public string TeachersTitle { get; set; }
    }
}
