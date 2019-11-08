using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TamilStudentsManagement_Dev.Models
{

    [Table("Master_Student")]
    public class StudentModel
    {
        [Key]
        public int Studentid
        {
            get;
            set;
        }
        [Required]
        public string FirstName
        {
            get;
            set;
        }
        [Required]
        public string LastName
        {
            get;
            set;
        }
        [Required]
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        [Required]
        public string Gender
        {
            get;
            set;
        }
        public string Attendance
        {
            get;
            set;
        }
        public string Comments
        {
            get;
            set;
        }

    }


    public class AttendanceDetail
    {
        /// <summary>  
        /// To hold list of orders  
        /// </summary>  
        public List<StudentsAttendanceAddModel> AttendanceDetails { get; set; }

    }

    [Table("Students_Attendance")]
    public class StudentsAttendanceAddModel
    {
        [Required]
        public int StudentID
        {
            get;
            set;
        }

        [Required]
        public bool Attendance
        {
            get;
            set;
        }

        [Required]
        public DateTime AttendanceDate
        {
            get;
            set;
        }

        [Required]
        public string Comments
        {
            get;
            set;
        }
    }
}
