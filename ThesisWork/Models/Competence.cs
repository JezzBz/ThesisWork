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

        
        [Required]
        //[ForeignKey("Граффик Id")]
        public int PracticeScheduleId {get;set;}

        [Column("Компетенция")]
        [Required]
        public string ThisCompetence { get; set; }

        
        
    }
}
