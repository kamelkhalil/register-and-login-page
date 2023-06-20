using Microsoft.EntityFrameworkCore;
using register_and_login_page.Models;

namespace register_and_login_page.Services
{
    public class R_LDbContext : DbContext
    {
        public R_LDbContext(DbContextOptions<R_LDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
