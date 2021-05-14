using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWork.Models
{
    [Table("Оценочная ведомость")]
    class MarksReport
    {
        [Key]
        public int id { get; set; }
        
        [Column("№ Зачет. книжки")]
        [Required]
        public Student Student { get; set; }

        [Column("Оценка")]
        [Required]
        public int Mark { get; set; }

        [Column("Учебный год")]
        [Required]
        public int EducationYear { get; set; }

    }
}
