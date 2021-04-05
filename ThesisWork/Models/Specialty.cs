using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWork.Models
{
    [Table("Специальности")]
    class Specialty
    {
       [Key]
       [Column("Направление")]      
       public string Vector { get; set; }

       [Column("Наименование направления")]
       [Required]
       public string VectorName { get; set; }
        
       [Column("Уровень образования")]
       [Required]
       public string EducationLevel { get; set; }

        [Column("Форма обучения")]
        [Required]
        public string EducationForm { get; set; }


    }
}
