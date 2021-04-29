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
    class PracticeBase
    {

        [Key]
        public int Id { get; set; }

        [Column("Уч. год")]
        [DisplayName("Уч. год")]
        [Required]
        public DateTime EducationYear { get; set; }

        [Column("Группа")]
        [DisplayName("Группа")]
        [Required]
        public string Group { get; set; }

        [Column("Студент")]
        [DisplayName("Студент")]
        [Required]
        public Student Student { get; set; }

        [Column("Id Графика практики")]
        [DisplayName("Id Графика практики")]
        [Required]
        public PracticeSchedule PracticeSchedule { get; set; }

        [Column("Название огранизации")]
        [DisplayName("Название огранизации")]
        [Required]
        public string CompanyName { get; set; }

        [Column("Индекс")]
        [DisplayName("Индекс")]
        [Required]
        public string Index { get; set; }

        [Column("Регион")]
        [DisplayName("Регион")]
        [Required]
        public string Area { get; set; }

        [Column("Город")]
        [DisplayName("Город")]
        [Required]
        public string City { get; set; }

        [Column("Улица")]
        [DisplayName("Улица")]
        [Required]
        public string Street { get; set; }

        [Column("Дом")]
        [DisplayName("Дом")]
        [Required]
        public string Building { get; set; }

        [Column("№ Договора ")]
        [DisplayName("№ Договора ")]
        [Required]
        public string DocumentNumber { get; set; }

        [Column("ФИО Руководителя предприятия")]
        [DisplayName("ФИО Руководителя предприятия")]
        [Required]
        public string  DirectorFCs  {get;set;}

        [Column("Должность руководителя предприятия")]
        [DisplayName("Должность руководителя предприятия")]
        [Required]
        public string  DirectorPos{get;set;}

        [Column("ФИО ответственного от профильной организации")]
        [DisplayName("ФИО ответственного от профильной организации")]
        [Required]
        public string ResponsibleFCs {get;set;}
        [Column("Должность ответственного от профильной организации")]
        [DisplayName("Должность ответственного от профильной организации")]
        [Required]
        public string ResponsiblePost  {get;set;}
}
}
