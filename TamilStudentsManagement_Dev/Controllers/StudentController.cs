using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TamilStudentsManagement_Dev.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TamilStudentsManagement_Dev.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            StudentContext studentcontext = new StudentContext();

            return View("Students", studentcontext.Students.ToList());
        }

       
    }
}
