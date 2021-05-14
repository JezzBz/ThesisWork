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
    [Table("Руководители практик")]
    class Teacher
    {
        [Key]
        [Required]
        [DisplayName("Табличный номер")]
        public int TabNumber { get; set; }
       
        [Column("Имя")]
        [DisplayName("Имя")]
        
        public string Name { get; set; }

        [Column("Фамилия")]
        [DisplayName("Фамилия")]
        
        public string Surname { get; set; }

        [Column("Отчество")]
        [DisplayName("Отчество")]
        
        public string Patronymic { get; set; }

        [Column("ФИО")]
        [DisplayName("ФИО")]
        
        public string FCs { get; set; }

        [Column("Должность")]
        [DisplayName("Должность")]
        
        public string Post { get; set; }

        [Column("Уч. степень")]
        [DisplayName("Уч. степень")]
        
        public string AcademicDegree { get; set; }
        [Column("Логин")]
        [DisplayName("Логин")]
        [Required]
        public string login { get; set; }

        [DisplayName("Ставка")]
        [Column("Ставка")]
        
        public string Rate { get; set; }
        [DisplayName("Штатность")]
        [Column("Штатность")]
        
        public string StaffingLevel { get; set; }
        [Column("Контактный телефон")]
        [DisplayName("Контактный телефон")]
        
        public string PhoneNumber { get; set; }
        [Column("Звание")]
        [DisplayName("Звание")]
        
        public string TeachersTitle { get; set; }
    }
}
