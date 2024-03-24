using LegajosApp.Infrastructure;
using LegajosApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LegajosApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMockRepository _mockRepository;

        public EmployeeController(IMockRepository mockRepository)
        {
            _mockRepository = mockRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEmployeeById(int id)
        {
            try
            {
               if(id <= 0) { throw new ArgumentException("Debe ingresar un numero mayor que cero"); }

                var employee = _mockRepository.GetById(id);
                return View("Index", employee);
            }
            catch (InvalidOperationException ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Index");
            }
            catch (ArgumentException ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
                return View("Index");
            }

        }
    }
}
