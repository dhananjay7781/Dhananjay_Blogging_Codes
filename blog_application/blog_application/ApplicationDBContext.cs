using blog_application.Model;
using Microsoft.EntityFrameworkCore;

namespace blog_application
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
