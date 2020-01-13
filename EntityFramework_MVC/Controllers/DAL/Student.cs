using System;

namespace EntityFramework_MVC
{
    public class Student
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public DateTime EnrollmentDate { get; internal set; }
    }
}