using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Column("Id Графика практики")]
        [DisplayName("Id Графика практики")]
        public int Id { get; set; }

        
        //[ForeignKey("Id")]
        [DisplayName("Id Практики")]
        [Required]
        public int PracticeId { get; set; }
        
        [Column("Уч. год")]
        [DisplayName("Уч. год")]
        [Required]
        public string EducationYear { get; set; }

        
        [Column("№ Группы")]
        [DisplayName("№ Группы")]
        [Required]
        public string GroupNumber { get; set; }

        [Column("Кол-во студентов")]
        [DisplayName("Кол-во студентов")]
        [Required]
        public int StudentsNumber { get; set; }

        [Column("ФИО Рук.Практики")]
        [DisplayName("ФИО Рук.Практики")]
        [Required]
        public string HeadFcs { get; set; }

        [Column("Направление")]
        [DisplayName("Направление")]
        [Required]
        public string Vector { get; set; }

        [Column("Дата начала")]
        [DisplayName("Дата начала")]
        [Required]
        public DateTime StartDate { get; set; }

        [Column("Дата конца")]
        [DisplayName("Дата конца")]
        [Required]
        public DateTime EndDate { get; set; }

        [Column("Кол-во недель")]
        [DisplayName("Кол-во недель")]
        [Required]
        public int WeeksNumber { get; set; }

        [Column("Часы СРС")]
        [DisplayName("Часы СРС")]
        [Required]
        public float HoursSRS { get; set; }

        [Column("Аудиторные часы")]
        [DisplayName("Аудиторные часы")]
        [Required]
        public float HoursClass { get; set; }

        [Column("Часы на зачёт")]
        [DisplayName("Часы на зачёт")]
        [Required]
        public float ExamenHours { get; set; }

        [Column("Лист")]
        [DisplayName("Лист")]
        [Required]
        public string SchedulePage { get; set; }
    }
}
