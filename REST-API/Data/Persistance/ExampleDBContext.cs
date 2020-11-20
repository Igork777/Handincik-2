using Exercise1.Models;
using Hand_In_2.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Hand_In_2.Data.Persistance
{
    public class ExampleDBContext :DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Adult> Adult { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Handin4.db");
        }
    }
}