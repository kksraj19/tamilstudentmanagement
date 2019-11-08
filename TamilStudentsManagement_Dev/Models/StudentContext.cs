using System;
using Microsoft.EntityFrameworkCore;


namespace TamilStudentsManagement_Dev.Models
{
    public class StudentContext : DbContext
    {
       
        public DbSet<MastersGradeModel> Grades { get; set; }

        public DbSet<StudentModel> Students { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = playground2017; User ID = sa; Password = Ashvik18");
        }
 
  
    }
}
