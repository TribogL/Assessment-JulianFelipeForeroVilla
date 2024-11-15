using Assessment_JulianFelipeForeroVilla.Data;
using Assessment_JulianFelipeForeroVilla.Models;

namespace Assessment_JulianFelipeForeroVilla.Seeders;
public class RolesSeeders
{
    public static void SeedRoles(ApplicationDbContext context)
    {
        var roles = new List<Role>
        {
            new Role { Id = 1, Name = "Patient", Description = "This role is for patients" },
            new Role { Id = 2, Name = "Doctor", Description = "This role is for doctors" }
        };

        foreach (var role in roles)
        {
            if (!context.Roles.Any(r => r.Id == role.Id))
            {
                context.Roles.Add(role);
            }
        }

        context.SaveChanges();
    }
}

