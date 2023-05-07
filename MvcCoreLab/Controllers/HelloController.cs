using Microsoft.AspNetCore.Mvc;
using MvcCoreLab.Models;

namespace MvcCoreLab.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Student()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Neetesh",
                Gender = "Male"
            };
            ViewBag.CurrentDate = DateTime.Now.ToShortDateString();
            ViewData["Title"] = "Dr.";
            string? location = Convert.ToString(TempData["Location"]);

            return View(student);
        }
    }
}
