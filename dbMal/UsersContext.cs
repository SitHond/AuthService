using AuthService.Models;
using Microsoft.EntityFrameworkCore;

namespace dbMal
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=DBMal;User Id=postgres;Password=qwerty");
        }
    }
}
