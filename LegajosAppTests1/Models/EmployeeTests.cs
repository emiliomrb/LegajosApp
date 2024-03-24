using Microsoft.VisualStudio.TestTools.UnitTesting;
using LegajosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegajosApp.Models.Tests
{
    [TestClass()]
    public class EmployeeTests
    {
        public Employee employee = new Employee()
        {
            Dni = 123,
            Name = "Cosme",
            Surname = "Fulanito"
        };

        [TestMethod()]
        public void GetNameAndSurnameTest()
        {
            Assert.AreEqual(employee.GetNameAndSurname(),"Fulanito, Cosme");
        }
    }
}