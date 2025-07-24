using Microsoft.EntityFrameworkCore;
using KtraMVC.Models;

namespace KtraMVC.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}

        public DbSet<Person> Persons { get; set; }
    }
}
