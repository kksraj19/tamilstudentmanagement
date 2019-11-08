using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TamilStudentsManagement_Dev.Models;

namespace TamilStudentsManagement_Dev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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



        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View("CreateStudent");
        }

        [HttpPost]
        public IActionResult CreateStudent(StudentModel studentModel)
        {
            string name = studentModel.FirstName;
            Console.WriteLine(name);

            StudentContext studentContext = new StudentContext();
            studentContext.Add(studentModel);
            studentContext.SaveChanges();

            return View("CreateStudent");
        }
    }
}
