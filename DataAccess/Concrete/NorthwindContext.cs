using Entities.Concrete;
using System.Data.Entity;

namespace DataAccess.Concrete
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}
