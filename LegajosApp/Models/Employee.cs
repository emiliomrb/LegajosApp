using System.ComponentModel.DataAnnotations;

namespace LegajosApp.Models
{
    public class Employee
    {
        public int Dni { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }

        public string GetNameAndSurname()
        {
            return $"{Surname}, {Name}";
        }
    }
}
