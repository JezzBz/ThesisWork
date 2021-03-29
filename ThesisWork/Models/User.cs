using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWork.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column("Имя")]
        [Required]
        public string Name { get; set; }

        [Column("Фамилия")]
        [Required]
        public string Surname { get; set; }

        [Column("Отчество")]
        [Required]
        public string Patronymic { get; set; }

        [Column("ФИО")]
        [Required]
        public string FCs { get; set; }

        [Column("Логин")]
        [Required]
        public string Login { get; set; }

        [Column("Пароль")]
        [Required]
        public string Password { get; set; }

        [Column("Роль")]
        [Required]
        public string Role { get; set; }

    }
}
