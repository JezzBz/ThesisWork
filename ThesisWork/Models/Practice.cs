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
        [Column("Название компании")]
        [Required]
        public string CompanyName { get; set; }

        [Column("Индекс")]
        [Required]
        public string Index { get; set; }

        [Column("Регион")]
        [Required]
        public string Region { get; set; }

        [Column("Город")]
        [Required]
        public string City { get; set; }

        [Column("Улица")]
        [Required]
        public string Street { get; set; }

        [Column("Дом")]
        [Required]
        public string Building { get; set; }
        [Column("Номер договора")]
        [Required]
        public string DocumentNumber { get; set; }

        [Column("Должность руководителя предприятия")]
        [Required]
        public string HeadOfCompanyPost { get; set; }
        [Column("ФИО руководителя предприятия")]
        [Required]
        public string HeadOfCompanyeFCs { get; set; }

        [Column("ФИО Ответственнного лица")]
        [Required]
        public string ResponsiblePersonFcs { get; set; }
        [Column("Должность Ответственнного лица")]
        [Required]
        public string ResponsiblePersonPost { get; set; }
    }
}
