using Microsoft.EntityFrameworkCore;
using VacationPlanner.Models;

namespace VacationPlanner.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        DbSet<User> Users { get; set; }
        
    }
}
