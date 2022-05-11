using Microsoft.EntityFrameworkCore;
using TBR.Core.Entities;

namespace TBR.Infrastructure.Data
{
    public class TBRDbContext : DbContext
    {
        //Connection to the database, and how you access the tables. 

        public TBRDbContext(string connection, bool isTestEnv)
        {
            _connection = connection;
            _isTestEnv = isTestEnv;
        }

        private readonly string _connection;

        private readonly bool _isTestEnv;
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLibrary> UserLibraries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (_isTestEnv)
            {
                options.UseInMemoryDatabase(_connection);
            }
            else
            {
                options.UseSqlServer(_connection);
            }
        }
    }

    
}
