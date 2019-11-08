using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TamilStudentsManagement_Dev.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TamilStudentsManagement_Dev.Controllers
{
    public class StudentAttendanceController : Controller
    {
        // GET: /<controller>/
        public IActionResult GetStudents()
        {
            try
            {
                StudentContext studentContext = new StudentContext();

                return View("StudentAttendance", studentContext.Students.ToList());
            }
            catch(Exception ex)
            {
                return View("StudentAttendance");
            }
        }

        [HttpGet]
        public IActionResult AddStudentAttendance()
        {
            try
            {
                StudentContext studentContext = new StudentContext();
                StudentModel studentModel = new StudentModel();
                
                return View("StudentAttendance", studentContext.Students.ToList());
            }
            catch (Exception ex)
            {
                return View("StudentAttendance");
            }
        }


        

        [HttpPost]
        public IActionResult AddStudentAttendance(List<StudentModel> studentModel)
        {
            try
            {
                
             int k = StudentAdd(studentModel);
             return View("Students", "Successfullyadded");
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int StudentAdd(List<StudentModel> obj)
        {
         
            StudentContext studentContext = new StudentContext();
            studentContext.Add(obj);
            studentContext.SaveChanges();

            //StudentContext studentcontext = new StudentContext();
            //String connectionString = "Data Source=localhost;Initial Catalog=playground2017;User ID=sa;Password=Ashvik18";

            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlCommand com = new SqlCommand("AddNewStudAttenDetails", conn);
            //com.CommandType = CommandType.StoredProcedure;
            //com.Parameters.AddWithValue("@Attendance", obj);
            //com.Parameters.AddWithValue("@AttendanceDate", obj.AttendanceDate);
            //com.Parameters.AddWithValue("@Comments", obj.Comments);
            //com.Parameters.AddWithValue("@StudentID", obj.StudentID);

            //conn.Open();
            //int i = com.ExecuteNonQuery();
            //conn.Close();
            //return i;


            //for(int i =0;i<=obj.Count;i++)
            //{
            //    studentContext.ad(obj[0].StudentID); 
            //}

            return 1;

        }




    }
}
