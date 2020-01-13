using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFramework_MVC.Models
{
    public class Person
    {
        public Person()
        {

        }

        public Person(int id, string lastname, string firstname, DateTime enrollmentdate)
        {
            ID = id;
            LastName = lastname;
            FirstName = firstname;
            EnrollmentDate = enrollmentdate;
        }

        public int ID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public override string ToString()
        {
            return string.Format("{0}{1}", this.ID, LastName);
        }
    }
}