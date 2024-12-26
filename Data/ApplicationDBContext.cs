using Microsoft.EntityFrameworkCore;
using ASP_Net_Core_MVC.Models.Entities;
namespace ASP_Net_Core_MVC.Data
{
    public class ApplicationDBContext:DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) { 
        
        }


        public DbSet<Student> Student {get; set; }
    }
}
