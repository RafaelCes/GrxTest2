using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrxTest2.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Display(Name = "Nome Completo")]
        public string? Name { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Boolean Active { get; set; } = true;
        [Display(Name = "Faixa Etaria")]
        public string AgeGroup
        {
            get
            {
                int age = DateTime.Now.Year - BirthDate.Year;
                if (age < 10) return "0 - 9";
                if (age < 20) return "10 - 19";
                if (age < 30) return "20 - 29";
                if (age < 40) return "30 - 39";
                else return "50+";
            }
        }
    }
}