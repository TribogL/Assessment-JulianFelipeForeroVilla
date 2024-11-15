
using Assessment_JulianFelipeForeroVilla.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_JulianFelipeForeroVilla.Data;
public class ApplicationDbContext : DbContext
{

    // public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}
