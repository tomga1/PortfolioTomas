using Microsoft.EntityFrameworkCore;
using PortfolioTomas.Models;

namespace PortfolioTomas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SobreMi> SobreMi {  get; set; }   
    }
}
