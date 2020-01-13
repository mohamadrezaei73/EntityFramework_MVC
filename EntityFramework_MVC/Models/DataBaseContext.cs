using System.Data.Entity;

namespace EntityFramework_MVC.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("Student")
        {

        }
 
        public DbSet<Person> People { get; set; }
    }
}