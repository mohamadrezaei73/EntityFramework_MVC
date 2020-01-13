using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EntityFramework_MVC
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("schoolContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBiulder)
        {
            modelBiulder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}