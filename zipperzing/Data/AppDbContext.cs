using Microsoft.EntityFrameworkCore;
using zipperzing.Models;

namespace zipperzing.Data
{ 
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}

}
