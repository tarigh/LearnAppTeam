using Microsoft.EntityFrameworkCore;

namespace LearnApp.Web.Models
{
    public class LearnAppContext : DbContext
    {
        public LearnAppContext(DbContextOptions<LearnAppContext> options) : base(options)
        {

        }

        public DbSet<ClassRoom> ClassRoom { get; set; }
        public DbSet<Student> Student { get; set; }

    }
}
