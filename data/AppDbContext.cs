using Microsoft.EntityFrameworkCore;
using uniqAPI.Models;

namespace uniqAPI.data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>opt):base(opt)
        {
            
        }
        public DbSet<Consumer> ConsumerTable { get; set; }
    }
}
