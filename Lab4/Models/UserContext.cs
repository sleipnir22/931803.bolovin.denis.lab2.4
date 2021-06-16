using Microsoft.EntityFrameworkCore;

namespace Lab4.Models {
    public class UserContext : DbContext {
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options) {
            Database.EnsureCreated();
        }
    }
}
