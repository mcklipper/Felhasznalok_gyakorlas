using Microsoft.EntityFrameworkCore;

namespace Felhasznalok
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                @"Data Source = (localdb)\MSSQLLocalDB; " +
                "Initial Catalog = felhasznalokGyak; " + 
                "Integrated Security = True;"
            );

            base.OnConfiguring(options);
        }
    }
}
