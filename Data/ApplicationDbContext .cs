
using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Assessment_JulianFelipeForeroVilla.Data;
public class ApplicationDbContext : DbContext
{

  public DbSet<Mourner> Mourners { get; set; }
  public DbSet<Doctor> Doctors { get; set; }
  public DbSet<Specialty> Specialties { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
  {
  }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    SpecialtySeeders.Seed(modelBuilder);
    MournerSeeders.Seed(modelBuilder);
    DoctorSeeders.Seed(modelBuilder);
  }
}
