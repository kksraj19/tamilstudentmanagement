using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TamilStudentsManagement_Dev.Models;
using System.Data.SqlClient;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TamilStudentsManagement_Dev.Controllers
{
    public class StudentSearchController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        //public ActionResult GetGrades()
        //{
        //    try
        //    {
        //        ViewData["Message"] = "Your application description page.";

        //        String connectionString = "Data Source=localhost;Initial Catalog=playground2017;User ID=sa;Password=Ashvik18";

        //        SqlConnection conn = new SqlConnection(connectionString);
        //        String sql = "SELECT * FROM Master_Grades";
        //        SqlCommand cmd = new SqlCommand(sql, conn);

        //        var model = new List<MastersGradeModel>();
        //        using (conn)
        //        {
        //            conn.Open();
        //            SqlDataReader rdr = cmd.ExecuteReader();
        //            while (rdr.Read())
        //            {
        //                var grade = new MastersGradeModel();
        //                grade.GradeID = Convert.ToInt32(rdr["GradeID"]);
        //                grade.GradeName = rdr["GradeName"].ToString();

        //                model.Add(grade);

        //            }

        //        }
        //        conn.Close();
        //        return View("Student", model);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        public ActionResult GetGrades()
        {
            StudentContext studentContext = new StudentContext();
            return View("Grades" , studentContext.Grades.ToList());

        }
    }
}
