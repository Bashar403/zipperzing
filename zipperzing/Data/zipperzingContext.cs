using Microsoft.EntityFrameworkCore;
using zipperzing.Models;

namespace zipperzing.Data
{ 
public class zipperzingContext : DbContext
{
    public zipperzingContext(DbContextOptions<zipperzingContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}

}
