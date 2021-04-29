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
    [Table("Компетенции")]
    class Competence
    {
        [Key]
        public int Id { get; set; }

        
       
        [Column("Компетенция")]
        [DisplayName("Компетенция")]
        [Required]
        public string ThisCompetence { get; set; }
        

        public List<PracticeSchedule> PracticesSchedule { get; set; }


    }
}
