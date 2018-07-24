using Microsoft.EntityFrameworkCore;

namespace asp.Models
{
    public class AppModelContext : DbContext
    {
       public AppModelContext (DbContextOptions<AppModelContext> options)
            : base(options)
        {
        }
        
        public DbSet<Movie> Movie { get;set;}   
    }
}