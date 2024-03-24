using LegajosApp.Models;
using LegajosApp.Models.Interfaces;

namespace LegajosApp.Infrastructure
{
    public class MockRepository : IMockRepository
    {
        private readonly List<Employee> _data;

        public MockRepository()
        {
            _data = new List<Employee>
            {
                new Employee { Dni = 111, Name = "Juan", Surname = "Gonzalez",  BirthDate =  new DateOnly(1980,01,25)},
                new Employee { Dni = 222, Name = "Sara", Surname = "Fernandez", BirthDate = new DateOnly(1982,10,06) },
                new Employee { Dni = 333, Name = "Pedro",Surname = "Suarez",  BirthDate =  new DateOnly(1987,9,14)},
                new Employee { Dni = 444, Name = "Lucia",Surname = "Perez",  BirthDate = new DateOnly(1988,4,11) }
            };
        }

        public Employee? GetById (int id)
        {
            var employee =  _data.Where(e => e.Dni == id).FirstOrDefault();

            if (employee == null)
            {
                throw new InvalidOperationException($"No se encontró ningún empleado con el DNI {id}.");
            }

            return employee;
        }
    }
}
