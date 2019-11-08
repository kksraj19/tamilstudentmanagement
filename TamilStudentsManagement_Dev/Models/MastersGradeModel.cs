using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TamilStudentsManagement_Dev.Models
{

    [Table("Master_Grades")]
    public class MastersGradeModel
    {
        public MastersGradeModel()
        {
        }

        [Key]
        public int GradeID
        {
            get;
            set;
        }
        public string GradeName
        {
            get;
            set;
        }

    }
}
