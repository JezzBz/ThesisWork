using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWork.Models
{
    [Table("Профиль")]
    class Profile
    {
        [Key]
        public string Group { get; set; }
        [Column("Направление")]
        [Required]
        public string Vector { get; set; }
        [Column("Название профиля")]
        [Required]
        public string ProfileName { get; set; }
        [Column("ФГОС")]
        [Required]
        public string FGOS { get; set; }


    }
}
