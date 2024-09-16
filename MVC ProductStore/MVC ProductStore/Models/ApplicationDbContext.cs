using Microsoft.EntityFrameworkCore;
using MVC_ProductStore.Models.Entities; // Pass på at dette er riktig namespace for Product-klassen

namespace MVC_ProductStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}