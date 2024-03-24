using Microsoft.VisualStudio.TestTools.UnitTesting;
using LegajosApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegajosApp.Models.Interfaces;
using LegajosApp.Models;
using Microsoft.AspNetCore.Mvc;
using LegajosApp.Infrastructure;

namespace LegajosApp.Controllers.Tests
{
    [TestClass()]
    public class EmployeeControllerTests
    {       

        [TestMethod]
        public void GetEmployeeById_ReturnsView_WhenEmployeeFound()
        {
            // Arrange
            var mockRepository = new MockRepository();
            var controller = new EmployeeController(mockRepository);

            // Act
            var result = controller.GetEmployeeById(123) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}