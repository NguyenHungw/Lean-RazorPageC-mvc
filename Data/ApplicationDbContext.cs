using AbbWeb_MVC.Model;
using Microsoft.EntityFrameworkCore;

namespace AbbWeb_MVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Category> Catagories { get; set; }

    }
}
