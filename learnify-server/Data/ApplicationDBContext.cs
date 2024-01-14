using learnify.Models;
using Microsoft.EntityFrameworkCore;

namespace learnify.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }
    }
}
