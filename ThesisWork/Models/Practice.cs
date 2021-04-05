using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWork.Models
{
    [Table("Практики")]
    class Practice
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Column("Название практики")]
        [Required]
        public string CompanyName { get; set; }

        [Column("Тип практики")]
        [Required]
        public string PracticeType { get; set; }

        [Column("Семестр")]
        [Required]
        public string Semestr { get; set; }

        [Column("Вид практики")]
        [Required]
        public string PracticeView { get; set; }

        [Column("Кол-во недель")]
        [Required]
        public int WeeksNumber { get; set; }
    }
}
