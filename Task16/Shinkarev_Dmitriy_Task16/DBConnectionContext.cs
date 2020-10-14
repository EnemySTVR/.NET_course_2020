using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DBConnectionContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Prize> Prizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Task16; Trusted_Connection=True");
        }
    }
}
