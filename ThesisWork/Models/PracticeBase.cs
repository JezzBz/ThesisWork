using System;
using System.Collections.Generic;
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
        [Required]
        public DateTime EducationYear { get; set; }

        [Column("Группа")]
        [Required]
        public string Group { get; set; }

        [Column("Студент")]
        [Required]
        public Student Student { get; set; }

        [Column("Id Графика практики")]
        [Required]
        public PracticeSchedule PracticeSchedule { get; set; }

        [Column("Название огранизации")]
        [Required]
        public string CompanyName { get; set; }

        [Column("Индекс")]
        [Required]
        public string Index { get; set; }

        [Column("Регион")]
        [Required]
        public string Area { get; set; }

        [Column("Город")]
        [Required]
        public string City { get; set; }

        [Column("Улица")]
        [Required]
        public string Street { get; set; }

        [Column("Дом")]
        [Required]
        public string Building { get; set; }

        [Column("№ Договора ")]
        [Required]
        public string DocumentNumber { get; set; }

        [Column("ФИО Руководителя предприятия")]
        [Required]
        public string  DirectorFCs  {get;set;}

        [Column("Должность руководителя предприятия")]
        [Required]
        public string  DirectorPos{get;set;}

        [Column("ФИО ответственного от профильной организации")]
        [Required]
        public string ResponsibleFCs {get;set;}
        [Column("Должность ответственного от профильной организации")]
        [Required]
        public string ResponsiblePost  {get;set;}
}
}
