using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TamilStudentsManagement_Dev.Models
{
    [Table("StudentsAttendance")]
    public class StudentAttendanceModel
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
