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
    }
}