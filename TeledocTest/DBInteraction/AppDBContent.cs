using Microsoft.EntityFrameworkCore;
using TeledocTest.Models;

namespace TeledocTest.DBInteraction
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Founder> Founders { get; set; }
    }
}