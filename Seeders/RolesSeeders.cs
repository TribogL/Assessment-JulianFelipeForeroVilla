using Assessment_JulianFelipeForeroVilla.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_JulianFelipeForeroVilla.Seeders;
public class RolesSeeders
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, Name = "Patient", Description = "This role is for patients" },
            new Role { Id = 2, Name = "Doctor", Description = "This role is for doctors" }
        );
    }
}

