using Microsoft.EntityFrameworkCore;

namespace JWTAuthDotNET.Data
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
        public DbSet<Entities.User> Users { get; set; } = null!;
    }
}
