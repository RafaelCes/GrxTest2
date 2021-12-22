using System.ComponentModel.DataAnnotations;

namespace GrxTest2.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Boolean Active { get; set; }
    }
}