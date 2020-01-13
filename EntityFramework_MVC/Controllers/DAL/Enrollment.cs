using EntityFramework_MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFramework_MVC
{
    public enum Grade
    {
        A, B, C, D, F

    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade Grade { get; set; }
        public virtual Course course { get; set; }
        public virtual Student Student { get; set; }

    }
}