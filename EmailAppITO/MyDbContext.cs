using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmailAppITO
{
    public class MyDbContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
    }
    
}