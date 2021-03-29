using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWork.Models
{
    [Table("Компетенции")]
    class Competence
    {
        [Key]
        public int Id { get; set; }

        [Column("Квалификация")]
        [Required]
        public string Qalification { get; set; }

        [Column("Описание")]
        [Required]
        public string Description { get; set; }
        [Column("Номер направления подготовки ")]
        [Required]
        public string VectorNumber{ get; set; }
        [Column("Название профиля")]
        [Required]
        public string ProfileName { get; set; }
    }
}
