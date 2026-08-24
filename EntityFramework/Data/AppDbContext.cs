using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
namespace EntityFramework.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Product>Products{get;set;}
}

