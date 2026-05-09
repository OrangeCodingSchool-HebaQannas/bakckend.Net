using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using tuples.Models;

namespace tuples.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Student studentData = new Student
            {
                Id = 101,
                Name = "John Doe",
                Age = 21
            };

            Course courseData = new Course
            {
                Id = 3001,
                CourseName = "ASP.NET MVC Development",
                InstructorName= "Dr. Jackie"

            };
            var modelData = Tuple.Create(studentData, courseData);

            return View(modelData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
