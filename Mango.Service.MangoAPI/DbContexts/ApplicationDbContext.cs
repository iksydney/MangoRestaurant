using Mango.Service.MangoAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mango.Service.MangoAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Product> Products {get; set; }
    }
}
