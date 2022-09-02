using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1
{
    public class MyDbContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
    }
    
}