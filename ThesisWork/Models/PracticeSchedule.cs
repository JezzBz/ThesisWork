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
        [Column("Id Графика практики")]
        public int Id { get; set; }

        [ForeignKey("Id Практики")]
        [Required]
        public Practice PracticeId { get; set; }
        
        [Column("Уч. год")]
        [Required]
        public string EducationYear { get; set; }

        [ForeignKey("№ Группы")]
        [Column("№ Группы")]
        [Required]
        public string GroupNumber { get; set; }

        [Column("Кол-во студентов")]
        [Required]
        public int StudentsNumber { get; set; }

        [Column("ФИО Рук.Практики")]
        [Required]
        public string HeadFcs { get; set; }

        [Column("Направление")]
        [Required]
        public string Vector { get; set; }

        [Column("Дата начала")]
        [Required]
        public DateTime StartDate { get; set; }

        [Column("Дата конца")]
        [Required]
        public DateTime EndDate { get; set; }

        [Column("Кол-во недель")]
        [Required]
        public int WeeksNumber { get; set; }

        [Column("Часы СРС")]
        [Required]
        public int HoursSRS { get; set; }

        [Column("Аудиторные часы")]
        [Required]
        public int HoursClass { get; set; }

        [Column("Часы на зачёт")]
        [Required]
        public int ExamenHours { get; set; }

        [Column("Лист")]
        [Required]
        public string SchedulePage { get; set; }
    }
}
